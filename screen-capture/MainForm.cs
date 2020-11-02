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
			InitializeComponent();
			Instance = this;
		}

		protected override void WndProc(ref Message m)
		{
			if (m.Msg == WM_HOTKEY)
			{
				switch ((int)m.WParam)
				{
					case (int)SHORTCUT_FUNCTION.CAPTURE_AT:
						MessageBox.Show(((int)m.WParam).ToString());
						break;
					case (int)SHORTCUT_FUNCTION.CAPTURE_FROM:
						MessageBox.Show(((int)m.WParam).ToString());
						break;
					case (int)SHORTCUT_FUNCTION.RECORD_AT:
						MessageBox.Show(((int)m.WParam).ToString());
						break;
					case (int)SHORTCUT_FUNCTION.RECORD_FROM:
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
	}
}
