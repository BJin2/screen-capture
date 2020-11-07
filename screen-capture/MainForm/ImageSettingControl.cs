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
			numImageRect.ValueChanged += numImageRect_ValueChanged;
		}
		public void LoadSetting()
		{
			numImageRect.LoadSetting();
			path.LoadSetting();
			selectShortcut.LoadSetting();
			allShortcut.LoadSetting();
			namingConvention.LoadSetting();
			autosaveCheckbox.Checked = (bool)Properties.Settings.Default["IMG_AUTOSAVE"];
			fileFormatList.SelectedIndex = (int)Properties.Settings.Default["IMG_FORMAT"];
			enableSelectShortcut.Checked = (bool)Properties.Settings.Default["IMG_SELECTION"];
			enableAllShortcut.Checked = (bool)Properties.Settings.Default["IMG_ALL"];

			//Controls affected by other controls
			selectShortcut.Enable(enableSelectShortcut.Checked);
			allShortcut.Enable(enableAllShortcut.Checked);
		}
		private void SaveSetting(object value, string key)
		{
			Properties.Settings.Default[key] = value;
			Properties.Settings.Default.Save();
		}

		#region value changed handlers
		private void numImageRect_ValueChanged(object sender, NumberChangeEventArgs e)
		{
			MainForm.Instance.RectNumberChanged(e.ChangedValue, e.CaptureType);
		}

		private void autosaveCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			SaveSetting(autosaveCheckbox.Checked, "IMG_AUTOSAVE");
			autosaveDetailPanel.Visible = autosaveCheckbox.Checked;
		}

		private void fileFormatList_SelectedIndexChanged(object sender, EventArgs e)
		{
			SaveSetting(fileFormatList.SelectedIndex, "IMG_FORMAT");
		}

		private void enableSelectShortcut_CheckedChanged(object sender, EventArgs e)
		{
			selectShortcut.Enable(enableSelectShortcut.Checked);
			SaveSetting(enableSelectShortcut.Checked, "IMG_SELECTION");
		}

		private void enableAllShortcut_CheckedChanged(object sender, EventArgs e)
		{
			allShortcut.Enable(enableAllShortcut.Checked);
			SaveSetting(enableAllShortcut.Checked, "IMG_ALL");
		}
	}
	#endregion
}
