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
		[DllImport("User32.dll")]
		public static extern bool ReleaseCapture();
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		public ImageRect()
		{
			InitializeComponent();
			this.SetStyle(ControlStyles.ResizeRedraw, true);

			titlePanel.MouseDown += title_MouseDown;

			top.MouseDown += resize_MouseDown;
			left.MouseDown += resize_MouseDown;
			right.MouseDown += resize_MouseDown;
			bottom.MouseDown += resize_MouseDown;
			topLeft.MouseDown += resize_MouseDown;
			topRight.MouseDown += resize_MouseDown;
			bottomLeft.MouseDown += resize_MouseDown;
			bottomRight.MouseDown += resize_MouseDown;
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
		}
	}
}
