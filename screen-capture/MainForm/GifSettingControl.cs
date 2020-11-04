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
	public partial class GifSettingControl : UserControl
	{
		public GifSettingControl()
		{
			InitializeComponent();
		}
		public void LoadSetting()
		{
			numGifRect.LoadSetting();
			path.LoadSetting();
			selectShortcut.LoadSetting();
			allShortcut.LoadSetting();
			autosaveCheckbox.Checked = (bool)Properties.Settings.Default["GIF_AUTOSAVE"];
			namingRule.Text = (string)Properties.Settings.Default["GIF_NAMING"];
			qualityList.SelectedIndex = (int)Properties.Settings.Default["GIF_QUALITY"];
			enableSelectShortcut.Checked = (bool)Properties.Settings.Default["GIF_SELECTION"];
			enableAllShortcut.Checked = (bool)Properties.Settings.Default["GIF_ALL"];

			//Controls affected by other controls
			selectShortcut.Enable(enableSelectShortcut.Checked);
			allShortcut.Enable(enableAllShortcut.Checked);
		}
		private void SaveSetting(object value, string key)
		{
			Properties.Settings.Default[key] = value;
			Properties.Settings.Default.Save();
		}

		#region control event handlers
		private void autosaveCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			SaveSetting(autosaveCheckbox.Checked, "GIF_AUTOSAVE");
		}

		private void namingRule_TextChanged(object sender, EventArgs e)
		{
			SaveSetting(namingRule.Text, "GIF_NAMING");
		}

		private void qualityList_SelectedIndexChanged(object sender, EventArgs e)
		{
			SaveSetting(qualityList.SelectedIndex, "GIF_QUALITY");
		}

		private void enableSelectShortcut_CheckedChanged(object sender, EventArgs e)
		{
			selectShortcut.Enable(enableSelectShortcut.Checked);
			SaveSetting(enableSelectShortcut.Checked, "GIF_SELECTION");
		}

		private void enableAllShortcut_CheckedChanged(object sender, EventArgs e)
		{
			allShortcut.Enable(enableAllShortcut.Checked);
			SaveSetting(enableAllShortcut.Checked, "GIF_ALL");
		}
		#endregion
	}
}
