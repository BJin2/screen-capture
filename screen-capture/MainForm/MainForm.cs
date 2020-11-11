using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
		#region winapi imported functions
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImport("user32.dll")]
		public static extern bool GetCursorInfo(out CURSORINFO pci);
		[DllImport("user32.dll")]
		public static extern bool GetIconInfo(IntPtr hIcon, out ICONINFO piconinfo);
		#endregion

		public static MainForm Instance { get; private set; }

		private List<Form> irects;
		private List<Form> grects;
		GifRect.GifRect temp;

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

			temp = new GifRect.GifRect(0);
			temp.Show();
		}

		protected override void WndProc(ref Message m)
		{
			if (m.Msg == WinMessage.WM_HOTKEY)
			{
				switch ((int)m.WParam)
				{
					case (int)SHORTCUT_FUNCTION.CAPTURE_SELECTION:
						MessageBox.Show(((int)m.WParam).ToString());
						break;
					case (int)SHORTCUT_FUNCTION.CAPTURE_ALL:
						CaptureAll();
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
			temp.Close();
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
				SendMessage(Handle, WinMessage.WM_NCLBUTTONDOWN, WinMessage.HTCAPTION, 0);
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
			var text = ct == CAPTURE_TYPE.IMG ? imageRectNumberLabel : gifRectNumberLabel;
			text.Text = num.ToString();

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

			if (diff == 0 || rects.Count == 0)
				return;

			diff *= -1;
			for (int i = 0; i < diff; i++)
			{
				rects.Last().Close();
				rects.RemoveAt(rects.Count - 1);
			}
		}

		public static ImageFormat GetImageFormat(string filename)
		{
			string ext = Path.GetExtension(filename).ToLower();
			ImageFormat imgfmt = ImageFormat.Bmp;
			if (ext != "")
			{
				switch (ext)
				{
					case ".jpg":
						imgfmt = ImageFormat.Jpeg;
						break;
					case ".png":
						imgfmt = ImageFormat.Png;
						break;
					case ".bmp":
						imgfmt = ImageFormat.Bmp;
						break;
					case ".tif":
						imgfmt = ImageFormat.Tiff;
						break;
				}
			}

			return imgfmt;
		}
		public static ImageFormat GetImageFormat(int formatIndex)
		{
			ImageFormat imgfmt = ImageFormat.Bmp;

			switch (formatIndex)
			{
				case 0:
					imgfmt = ImageFormat.Bmp;
					break;
				case 1:
					imgfmt = ImageFormat.Jpeg;
					break;
				case 2:
					imgfmt = ImageFormat.Png;
					break;
				case 3:
					imgfmt = ImageFormat.Tiff;
					break;
			}

			return imgfmt;
		}
		public static void DrawMousePointer(Graphics g, int x, int y)
		{
			IntPtr hIcon;
			CURSORINFO cursorInfo = new CURSORINFO();
			cursorInfo.cbSize = Marshal.SizeOf(cursorInfo);
			if (GetCursorInfo(out cursorInfo))
			{
				if (cursorInfo.flags == WinMessage.CURSOR_SHOWING)
				{
					hIcon = cursorInfo.hCursor;
					if (GetIconInfo(hIcon, out ICONINFO iconInfo))
					{
						g.DrawIcon(Icon.FromHandle(hIcon), x - ((int)iconInfo.xHotspot), y - ((int)iconInfo.yHotspot));
					}
				}
			}
		}

		#region Shortcut functions
		private void CaptureAll()
		{
			for (int i = 0; i < irects.Count; i++)
			{
				(irects[i] as ImgRect).CaptureInternalRect();
			}
		}
		#endregion
	}
}
