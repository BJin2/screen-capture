using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace screen_capture
{
	public partial class MainForm : Form
	{
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int WM_HOTKEY = 0x312;
		public const int HTCAPTION = 0x2;
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		public static MainForm Instance { get; private set; }

		public MainForm()
		{
			Instance = this;
			InitializeComponent();
			generalSetting.LoadSetting();
			imageSetting.LoadSetting();
			gifSetting.LoadSetting();

			titlePanel.MouseDown += titleBar_MouseDown;
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

		#region Title bar
		private void closeButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void minimizeButton_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void titleBar_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
			}
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
