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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;
using System.Windows.Media.Imaging;

namespace screen_capture.GifRect
{
	public partial class GifRect : Form
	{
		#region winapi imported functions
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		#endregion

		private readonly int id;
		private readonly int minWidth;
		private readonly int widthOffset;
		private readonly int minHeight;

		private bool recording;
		private GifBitmapEncoder encoder;

		public GifRect(int _id)
		{
			id = _id;
			recording = false;

			InitializeComponent();
			SetStyle(ControlStyles.ResizeRedraw, true);

			minWidth = recordButton.Width + saveButton.Width + clearButton.Width;
			widthOffset = left.Width + right.Width;
			minHeight = titlePanel.Height + top.Height + bottom.Height;

			Load += GifRect_Load;
			LocationChanged += Form_LocationChanged;
			SizeChanged += Form_SizeChanged;
			titlePanel.MouseDown += title_MouseDown;
			AddBorderResizeHandler(borderPanel);
			AddSizePositionHandler(textArea);

			LoadSize();
			LoadLocation();
		}

		#region Save & Load setting
		private void LoadSize()
		{
			Size size;
			try
			{
				size = (Size)Properties.Settings.Default["GIF_" + id.ToString() + "_RES"];
			}
			catch // Record box opens in fixed size if error occurs while loading size value
			{
				//MessageBox.Show("Record Box Size Load Failed");
				size = new Size(minWidth + 128, minHeight + 128);
			}
			this.Size = size;
		}
		private void SaveSize()
		{
			try
			{
				Properties.Settings.Default["GIF_" + id.ToString() + "_RES"] = this.Size;
				Properties.Settings.Default.Save();
			}
			catch
			{
				//MessageBox.Show("Record Box Size Save Failed");
			}
		}

		private void LoadLocation()
		{
			Point point;
			try
			{
				point = (Point)Properties.Settings.Default["GIF_" + id.ToString() + "_POS"];
			}
			catch // Record box opens in fixed location if error occurs while loading position
			{
				//MessageBox.Show("Record Box Location Load Failed");
				point = new Point(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2);
			}
			this.Location = point;
		}
		private void SaveLocation()
		{
			try
			{
				string prefix = "GIF_" + id.ToString();
				Properties.Settings.Default[prefix + "_POS"] = this.Location;
				Properties.Settings.Default.Save();
			}
			catch
			{
				//MessageBox.Show("Record Box Location Save Failed");
			}
		}
		#endregion

		#region Add event handler
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
		private void AddBorderResizeHandler(Panel p)
		{
			if (p == recordArea || p.GetType() != typeof(Panel))
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
		#endregion

		#region Size Location Handler
		//Using window message
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

		//Limit input to numbers only
		private void Textbox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		//Finish receiving input. Change size or location
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

		//After value changed
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
		#endregion

		#region Modify size & location
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

		#region Event handlers releated to gif recording
		private void recordButton_Click(object sender, EventArgs e)
		{
			if (recording)
			{
				StopRecording();
			}
			else
			{
				StartRecording();
			}
		}
		private void clearButton_Click(object sender, EventArgs e)
		{

		}
		private void saveButton_Click(object sender, EventArgs e)
		{

		}
		#endregion

		#region Recording
		public void StartRecording()
		{
			recording = true;
			recordButton.ImageIndex = 1;

			int quality;
			int interval;

			encoder = new GifBitmapEncoder();

			try
			{
				interval = (int)Properties.Settings.Default[""];
				quality = (int)Properties.Settings.Default[""];
			}
			catch
			{
				interval = 33;
				quality = 2;
			}

			int numFrame = 60;

			#region Async task until recording becomes false
			//TODO change to recording
			//TODO async task(apart from main thread so processing image data and window default behaviors can work at the same time
			while (numFrame > 0)
			{
				Rectangle rect = new Rectangle(this.Left + left.Width,
												this.Top + minHeight - bottom.Height,
												this.Left + left.Width + this.Width - widthOffset,
												this.Top + minHeight - bottom.Height + this.Height - minHeight);
				Bitmap bm = MainForm.CaptureRect(rect, quality);

				/*/
				gifDataModifier.AddFrame(bm, 33);
				/*/
				BitmapSizeOptions size = BitmapSizeOptions.FromEmptyOptions();
				BitmapSource bitmapSource = Imaging.CreateBitmapSourceFromHBitmap(bm.GetHbitmap(), IntPtr.Zero, System.Windows.Int32Rect.Empty, size);
				BitmapFrame frame = BitmapFrame.Create(bitmapSource);
				encoder.Frames.Add(frame);
				//*/
				numFrame--;
				Thread.Sleep(interval);
			}
			#endregion
		}
		public void StopRecording()
		{
			recording = false;
			recordButton.ImageIndex = 0;

			AutoSave();
		}
		private void SaveGif(string path)
		{
			MemoryStream ms = new MemoryStream();
			encoder.Save(ms);

			List<byte> gifData = new List<byte>(ms.ToArray());
			GifDataModifier.ChangeDelay(gifData, 6);
			GifDataModifier.Save(path, gifData);
		}
		private void AutoSave()
		{
			#region Defining file path and file name
			//TODO Make this part as a static function of NamingConvention So that ImageRect and GifRect can share
			List<int> namingTemplate = NamingConvention.SaveValueToInt((string)Properties.Settings.Default["IMG_NAMING"]);
			string formatString = "." + ImageFormat.Gif.ToString().ToLower();
			string path = (string)Properties.Settings.Default["IMG_PATH"];
			
			if (DirectoryControl.DirectoryCheckCreate(path))
				path += "\\" + NamingConvention.TemplateToName(namingTemplate) + formatString;
			else
			{
				MessageBox.Show(path + "\n Directory not found.\nCould not save image automaically.", "Auto Save Failed");
				return;
			}

			int insertIndex = path.Length - formatString.Length;
			int i = 0;
			while (File.Exists(path))
			{
				if (i == 0)
					path = path.Insert(insertIndex, "(" + i.ToString() + ")");
				else
					path = path.Replace("(" + (i - 1).ToString() + ")", "(" + i.ToString() + ")");
				i++;
			}
			#endregion

			SaveGif(path);
			Clear();
		}
		private void Clear()
		{
			encoder.Frames.Clear();
			encoder = null;
		}
		#endregion

		#region Utils
		private void LoseControlFocus()
		{
			this.ActiveControl = textArea;
		}
		private void GifRect_Load(object sender, EventArgs e)
		{
			//Change focus to non-interactive element
			LoseControlFocus();
		}
		private void EnableSizeText(bool e)
		{
			resWidth.Enabled = e;
			resHeight.Enabled = e;
		}
		private void borderPanel_EnalbedChanged(object sender, EventArgs e)
		{
			EnableSizeText((sender as Panel).Enabled);
		}

		#endregion

		
	}
}
