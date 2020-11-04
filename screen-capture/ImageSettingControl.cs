using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace screen_capture
{
	public partial class ImageSettingControl : UserControl
	{
		public ImageSettingControl()
		{
			InitializeComponent();
			LoadSetting();
		}
		private void LoadSetting()
		{
			autosaveCheckbox.Checked = (bool)Properties.Settings.Default["IMG_AUTOSAVE"];
			namingRule.Text = (string)Properties.Settings.Default["IMG_NAMING"];
			fileFormatList.SelectedIndex = (int)Properties.Settings.Default["IMG_FORMAT"];
			enableSelectShortcut.Checked = (bool)Properties.Settings.Default["IMG_SELECTION"];
			enableAllShortcut.Checked = (bool)Properties.Settings.Default["IMG_ALL"];
		}
		private void SaveSetting()
		{
			Properties.Settings.Default["IMG_AUTOSAVE"] = autosaveCheckbox.Checked;
			Properties.Settings.Default["IMG_NAMING"] = namingRule.Text;
			Properties.Settings.Default["IMG_FORMAT"] = fileFormatList.SelectedIndex;
			Properties.Settings.Default["IMG_SELECTION"] = enableSelectShortcut.Checked;
			Properties.Settings.Default["IMG_ALL"] = enableAllShortcut.Checked;
		}

		private void autosaveCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			SaveSetting();
		}

		private void namingRule_TextChanged(object sender, EventArgs e)
		{
			SaveSetting();
		}

		private void fileFormatList_SelectedIndexChanged(object sender, EventArgs e)
		{
			SaveSetting();
		}

		private void enableSelectShortcut_CheckedChanged(object sender, EventArgs e)
		{
			if (enableSelectShortcut.Checked)
				selectShortcut.Enable();
			else
				selectShortcut.Disable();

			SaveSetting();
		}

		private void enableAllShortcut_CheckedChanged(object sender, EventArgs e)
		{
			if (enableAllShortcut.Checked)
				allShortcut.Enable();
			else
				allShortcut.Disable();

			SaveSetting();
		}
	}
}
