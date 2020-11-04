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
			LoadSetting();
		}

		private void LoadSetting()
		{
			topCheckbox.Checked = (bool)Properties.Settings.Default["AlwaysTop"];
			syncCheckbox.Checked = (bool)Properties.Settings.Default["Sync"];
		}

		private void SaveSetting()
		{
			Properties.Settings.Default["AlwaysTop"] = topCheckbox.Checked;
			Properties.Settings.Default["Sync"] = syncCheckbox.Checked;
			Properties.Settings.Default.Save();
		}

		private void syncCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			SaveSetting();
			//TODO sync both settings
		}

		private void topCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			SaveSetting();
			MainForm.Instance.TopMost = topCheckbox.Checked;
		}
	}
}
