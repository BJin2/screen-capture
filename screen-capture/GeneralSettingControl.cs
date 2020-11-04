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
	public partial class GeneralSettingControl : UserControl
	{
		public GeneralSettingControl()
		{
			InitializeComponent();
		}

		public void LoadSetting()
		{
			topCheckbox.Checked = (bool)Properties.Settings.Default["AlwaysTop"];
			syncCheckbox.Checked = (bool)Properties.Settings.Default["Sync"];
		}

		private void SaveSetting(object value, string key)
		{
			Properties.Settings.Default[key] = value;
			Properties.Settings.Default.Save();
		}

		private void syncCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			SaveSetting(syncCheckbox.Checked, "Sync");
			//TODO sync both settings
		}

		private void topCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			SaveSetting(topCheckbox.Checked, "AlwaysTop");
			MainForm.Instance.TopMost = topCheckbox.Checked;
		}
	}
}
