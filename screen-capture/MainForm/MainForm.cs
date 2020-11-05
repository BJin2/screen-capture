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

using ImgRect = screen_capture.ImageRect.ImageRect;

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
		private List<Form> irects;
		private List<Form> grects;
		public MainForm()
		{
			Instance = this;
			irects = new List<Form>();
			grects = new List<Form>();

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
			if (irects != null && irects.Count > 0)
			{
				foreach (ImgRect r in irects)
				{
					r.Close();
				}
			}
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

		#region button event handler
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
		#endregion

		public void RectNumberChanged(int num, CAPTURE_TYPE ct)
		{
			var rects = ct == CAPTURE_TYPE.IMG ? irects : grects;
			int diff = num - rects.Count;

			if (diff > 0)
			{
				for (int i = 0; i < diff; i++)
				{
					int id = rects.Count;
					if (ct == CAPTURE_TYPE.IMG)
					{
						rects.Add(new ImgRect(id));
					}
					else if (ct == CAPTURE_TYPE.GIF)
					{
						//TODO change ImgRect to GifRect
						rects.Add(new ImgRect(id));
					}
					rects.Last().Show();
				}
				return;
			}

			if (rects.Count == 0)
				return;

			//sudden removal of multiple capture rects never happens(except closing the whole app)
			//Remove count 1 is guaranteed
			rects.Last().Close();
			rects.RemoveAt(rects.Count - 1);
		}
	}
}
