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

namespace screen_capture.ImageRect
{
	public partial class ImageRect : Form
	{
		#region winapi imported functions
		[DllImport("User32.dll")]
		public static extern bool ReleaseCapture();
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		#endregion

		private readonly int id;

		public ImageRect(int _id)
		{
			id = _id;
			InitializeComponent();
			this.SetStyle(ControlStyles.ResizeRedraw, true);
			titlePanel.MouseDown += title_MouseDown;

			foreach (var p in borderPanel.Controls)
			{
				if (p == captureArea ||
					p.GetType() != typeof(Panel))
					continue;

				AddBorderResizeHandler((Panel)p);
			}

			LoadSize();
		}

		#region Save & Load Size
		private void LoadSize()
		{
			int x;
			int y;
			int width;
			int height;
			try
			{
				string prefix = "IMG_" + id.ToString();
				x = (int)Properties.Settings.Default[prefix + "_X" ];
				y = (int)Properties.Settings.Default[prefix + "_Y"];
				width = (int)Properties.Settings.Default[prefix + "_WIDTH"];
				height = (int)Properties.Settings.Default[prefix + "_HEIGHT"];
			}
			catch // Capture box opens in fixed size if error occurs while loading position or size value
			{
				width = 128 + 10;
				height = 128 + 10 + titlePanel.Height;
				x = (Screen.PrimaryScreen.Bounds.Width / 2) - (width/2);
				y = (Screen.PrimaryScreen.Bounds.Height / 2) - (height/2);
			}
			Location = new Point(x, y);
			Size = new Size(width, height);
		}
		private void SaveSize()
		{
			try
			{
				string prefix = "IMG_" + id.ToString();
				Properties.Settings.Default[prefix + "_X"] = Location.X;
				Properties.Settings.Default[prefix + "_Y"] = Location.Y;
				Properties.Settings.Default[prefix + "_WIDTH"] = Size.Width;
				Properties.Settings.Default[prefix + "_HEIGHT"] = Size.Height;
			}
			catch
			{
				MessageBox.Show("Capture Box Properties Save Failed");
			}
		}
		#endregion

		#region Capture
		#endregion

		#region Window behavior
		private void AddBorderResizeHandler(Panel p)
		{
			if (!p.HasChildren)
			{
				p.MouseDown += resize_MouseDown;
				return;
			}

			foreach (var panel in p.Controls)
			{
				AddBorderResizeHandler((Panel)panel);
			}
		}

		private void title_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left)
				return;
			ReleaseCapture();
			SendMessage(this.Handle, WinMessage.WM_NCLBUTTONDOWN, WinMessage.HTCAPTION, 0);
		}

		private void resize_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left)
				return;
			ReleaseCapture();
			SendMessage(this.Handle, WinMessage.WM_NCLBUTTONDOWN, WinMessage.HITTEST[((Panel)sender).Name], 0);
			SaveSize();
		}
		#endregion
	}
}
