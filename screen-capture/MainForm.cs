using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace screen_capture
{
	public partial class MainForm : Form
	{
		public const int WM_HOTKEY = 0x312;

		public static MainForm Instance { get; private set; }

		public MainForm()
		{
			Instance = this;
			InitializeComponent();
			generalSetting.LoadSetting();
			imageSetting.LoadSetting();
			gifSetting.LoadSetting();
		}

		protected override void WndProc(ref Message m)
		{
			if (m.Msg == WM_HOTKEY)
			{
				switch ((int)m.WParam)
				{
					case (int)SHORTCUT_FUNCTION.CAPTURE_SELECTION:
						MessageBox.Show(((int)m.WParam).ToString());
						break;
					case (int)SHORTCUT_FUNCTION.CAPTURE_ALL:
						MessageBox.Show(((int)m.WParam).ToString());
						break;
					case (int)SHORTCUT_FUNCTION.RECORD_SELECTION:
						MessageBox.Show(((int)m.WParam).ToString());
						break;
					case (int)SHORTCUT_FUNCTION.RECORD_ALL:
						MessageBox.Show(((int)m.WParam).ToString());
						break;
					default:
						MessageBox.Show("Undefined Hotkey");
						break;
				}
			}
			else
			{
				base.WndProc(ref m);
			}
		}

		#region Title bar buttons
		private void closeButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void minimizeButton_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		#endregion

		private void generalButton_Click(object sender, EventArgs e)
		{
			generalSetting.BringToFront();
		}

		private void imageButton_Click(object sender, EventArgs e)
		{
			imageSetting.BringToFront();
		}

		private void gifButton_Click(object sender, EventArgs e)
		{
			gifSetting.BringToFront();
		}
	}
}
