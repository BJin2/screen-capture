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
			numGifRect.ValueChanged += numGifRect_ValueChanged;
		}
		public void LoadSetting()
		{
			numGifRect.LoadSetting();
			path.LoadSetting();
			selectShortcut.LoadSetting();
			allShortcut.LoadSetting();
			namingConvention.LoadSetting();
			autosaveCheckbox.Checked = (bool)Properties.Settings.Default["GIF_AUTOSAVE"];
			qualityList.SelectedIndex = (int)Properties.Settings.Default["GIF_QUALITY"];
			frameRate.SelectedIndex = (int)Properties.Settings.Default["GIF_FRAME"];
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
		private void numGifRect_ValueChanged(object sender, NumberChangeEventArgs e)
		{
			MainForm.Instance.RectNumberChanged(e.ChangedValue, e.CaptureType);
		}

		private void autosaveCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			SaveSetting(autosaveCheckbox.Checked, "GIF_AUTOSAVE");
			autosaveDetailPanel.Visible = autosaveCheckbox.Checked;
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
		
		private void frameRate_SelectedIndexChanged(object sender, EventArgs e)
		{
			SaveSetting(frameRate.SelectedIndex, "GIF_FRAME");
		}
		#endregion
	}
}
