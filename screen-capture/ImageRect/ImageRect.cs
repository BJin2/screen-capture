using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
		private readonly int minWidth;
		private readonly int widthOffset;
		private readonly int minHeight;

		public ImageRect(int _id)
		{
			id = _id;
			InitializeComponent();
			this.SetStyle(ControlStyles.ResizeRedraw, true);

			this.Load += ImageRect_Load;
			this.LocationChanged += Form_LocationChanged;
			this.SizeChanged += Form_SizeChanged;

			titlePanel.MouseDown += title_MouseDown;
			AddBorderResizeHandler(borderPanel);
			
			AddSizePositionHandler(textArea);

			minWidth = textArea.Width + captureButton.Width + saveButton.Width + clearButton.Width;
			widthOffset = left.Width + right.Width;
			minHeight = titlePanel.Height + top.Height + bottom.Height;

			StartPosition = FormStartPosition.Manual;

			LoadSize();
			LoadLocation();
		}

		#region Modify Size Location
		private void Form_LocationChanged(object sender, EventArgs e)
		{
			coordX.Enabled = false;
			coordY.Enabled = false;
			coordX.Text = this.Location.X.ToString();
			coordY.Text = this.Location.Y.ToString();
			coordX.Enabled = true;
			coordY.Enabled = true;
			SaveLocation();
		}
		private void Form_SizeChanged(object sender, EventArgs e)
		{
			resWidth.Enabled = false;
			resHeight.Enabled = false;
			resWidth.Text = (this.Size.Width - widthOffset).ToString();
			resHeight.Text = (this.Size.Height - minHeight).ToString();
			resWidth.Enabled = true;
			resHeight.Enabled = true;
			SaveSize();
		}

		private void AddSizePositionHandler(Control c)
		{
			if (!c.HasChildren)
			{
				if (c.GetType() == typeof(TextBox))
				{
					var textbox = c as TextBox;
					textbox.KeyPress += Textbox_KeyPress;
					textbox.KeyDown += Textbox_KeyDown;
					textbox.LostFocus += Textbox_LostFocus;
				}
				return;
			}

			foreach (var control in c.Controls)
			{
				AddSizePositionHandler(control as Control);
			}
		}
		private void Textbox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}
		private void Textbox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter)
				return;

			ChangeSizePosition(sender as TextBox);
			LoseControlFocus();
		}
		private void Textbox_LostFocus(object sender, EventArgs e)
		{
			ChangeSizePosition(sender as TextBox);
		}
		private void ChangeSizePosition(TextBox textbox)
		{
			if (textbox.Text == "" || !textbox.Enabled)
				return;
			int value = int.Parse(textbox.Text);

			switch (textbox.Name)
			{
				case "coordX":
					this.Location = new Point(value, this.Location.Y);
					break;
				case "coordY":
					this.Location = new Point(this.Location.X, value);
					break;
				case "resWidth":
					if (!borderPanel.Enabled)
						return;
					int width = value + widthOffset;
					this.Size = new Size(width, this.Size.Height);
					break;
				case "resHeight":
					if (!borderPanel.Enabled)
						return;
					int height = value + minHeight;
					this.Size = new Size(this.Size.Width, height);
					break;
				default:
					MessageBox.Show("Size, Position Error");
					break;
			}
		}
		#endregion

		#region Save & Load Size & Location
		private void LoadSize()
		{
			Size size;
			try
			{
				size = (Size)Properties.Settings.Default["IMG_" + id.ToString() + "_RES"];
			}
			catch // Capture box opens in fixed size if error occurs while loading size value
			{
				MessageBox.Show("Capture Box Size Load Failed");
				
				size = new Size(minWidth + 128, minHeight + 128);
			}
			this.Size = size;
		}
		private void SaveSize()
		{
			try
			{
				Properties.Settings.Default["IMG_" + id.ToString() + "_RES"] = this.Size;
				Properties.Settings.Default.Save();
			}
			catch
			{
				MessageBox.Show("Capture Box Properties Save Failed");
			}
		}

		private void LoadLocation()
		{
			Point point;
			try
			{
				point = (Point)Properties.Settings.Default["IMG_" + id.ToString() + "_POS"];
			}
			catch // Capture box opens in fixed location if error occurs while loading position
			{
				MessageBox.Show("Capture Box Location Load Failed");
				point = new Point(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2);
			}
			this.Location = point;
		}
		private void SaveLocation()
		{
			try
			{
				string prefix = "IMG_" + id.ToString();
				Properties.Settings.Default[prefix + "_POS"] = this.Location;
				Properties.Settings.Default.Save();
			}
			catch
			{
				MessageBox.Show("Capture Box Location Save Failed");
			}
		}
		#endregion

		#region Capture
		private void captureButton_Click(object sender, EventArgs e)
		{
			CaptureInternalRect();
			//TODO autosave
			if ((bool)Properties.Settings.Default["IMG_AUTOSAVE"])
			{
				string naming = (string)Properties.Settings.Default["IMG_NAMING"];
				ImageFormat format = MainForm.GetImageFormat((int)Properties.Settings.Default["IMG_FORMAT"]);
				Clear();
			}
		}
		private void saveButton_Click(object sender, EventArgs e)
		{
			if (captured.Image == null)
				return;

			string filename;
			ImageFormat format;
			saveFile.FileName = "";
			if (saveFile.ShowDialog() == DialogResult.OK)
			{
				filename = saveFile.FileName;
				format = MainForm.GetImageFormat(filename);
				this.captured.Image.Save(filename, format);
			}
		}
		private void clearButton_Click(object sender, EventArgs e)
		{
			Clear();
		}

		private void Clear()
		{
			captured.BackColor = Color.FromArgb(224, 224, 224);
			captured.Image = null;
			borderPanel.Enabled = true;
		}
		private void CaptureRect(Rectangle rect)
		{
			Clear();
			captured.BackColor = Color.White;
			int width = rect.Width - rect.Left;
			int height = rect.Height - rect.Top;
			Bitmap bm = new Bitmap(width, height);
			Graphics g = Graphics.FromImage(bm);
			g.CopyFromScreen(rect.Left, rect.Top, 0, 0, new Size(width, height));
			//TODO make draw cursor option
			MainForm.DrawMousePointer(g, Cursor.Position.X - rect.Left, Cursor.Position.Y - rect.Top);

			captured.Image = bm;
			borderPanel.Enabled = false;
		}
		public void CaptureInternalRect()
		{
			Rectangle rect = new Rectangle(this.Left + left.Width,
											this.Top + minHeight - bottom.Height,
											this.Left + left.Width + this.Width - widthOffset,
											this.Top + minHeight - bottom.Height + this.Height - minHeight);
			CaptureRect(rect);
		}
		public void CaptureWholeRect()
		{
			Rectangle rect = new Rectangle(this.Left,
											this.Top,
											this.Left + this.Width,
											this.Top + this.Height);
			CaptureRect(rect);
		}
		#endregion

		#region Window behavior
		private void LoseControlFocus()
		{
			this.ActiveControl = textArea;
		}
		
		private void AddBorderResizeHandler(Panel p)
		{
			if (p == captureArea || p.GetType() != typeof(Panel))
				return;

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
		private void EnableSizeText(bool e)
		{
			resWidth.Enabled = e;
			resHeight.Enabled = e;
		}

		private void ImageRect_Load(object sender, EventArgs e)
		{
			//Change focus to non-interactive element
			LoseControlFocus();
		}

		private void borderPanel_EnalbedChanged(object sender, EventArgs e)
		{
			EnableSizeText((sender as Panel).Enabled);
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
			if (e.Button != MouseButtons.Left || !borderPanel.Enabled)
				return;
			ReleaseCapture();
			SendMessage(this.Handle, WinMessage.WM_NCLBUTTONDOWN, WinMessage.HITTEST[((Panel)sender).Name], 0);
		}
		#endregion
	}
}
