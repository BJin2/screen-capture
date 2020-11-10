using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms.VisualStyles;

namespace screen_capture
{
	public enum CAPTURE_TYPE
	{
		NONE,
		IMG,
		GIF
	}

	public partial class DirectoryControl : UserControl
	{
		public string Path { get; private set; }
		[DefaultValue(SHORTCUT_FUNCTION.NONE)]
		public CAPTURE_TYPE CaptureType{get; set;}

		public DirectoryControl()
		{
			InitializeComponent();
			pathBox.KeyDown += pathBox_KeyDown;
			pathBox.LostFocus += pathBox_LostFocus;
		}

		#region Save Load
		public void LoadSetting()
		{
			if (CaptureType == CAPTURE_TYPE.NONE)
			{
				SetPath(Environment.GetFolderPath(folderBrowserDialog.RootFolder));
				return;
			}
			SetPath((string)Properties.Settings.Default[CaptureType.ToString() + "_PATH"]);
		}
		private void SaveSetting()
		{
			if (CaptureType == CAPTURE_TYPE.NONE)
				return;
			Properties.Settings.Default[CaptureType.ToString() + "_PATH"] = Path;
			Properties.Settings.Default.Save();
		}
		#endregion

		#region Control event handlers
		private void openButton_Click(object sender, EventArgs e)
		{
			if (!DirectoryCheckCreate(Path))
				return;

			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				Arguments = Path,
				FileName = "explorer.exe"
			};
			Process.Start(startInfo);
		}

		private void browseButton_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				SetPath(folderBrowserDialog.SelectedPath);
			}
		}

		private void pathBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter)
				return;

			SetPath(pathBox.Text);
		}
		private void pathBox_LostFocus(object sender, EventArgs e)
		{
			SetPath(pathBox.Text);
		}
		#endregion

		private void SetPath(string path)
		{
			if (path == "")
				path = Environment.GetFolderPath(folderBrowserDialog.RootFolder);
			Path = path;
			pathBox.Text = Path;
			SaveSetting();
		}

		public static bool DirectoryCheckCreate(string path)
		{
			if (!Directory.Exists(path))
			{
				if (MessageBox.Show(path + "Directory not found.\nCreate directory as you entered?", "Directory Error", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					Directory.CreateDirectory(path);
				}
				else
				{
					return false;
				}
			}

			return true;
		}
	}
}
