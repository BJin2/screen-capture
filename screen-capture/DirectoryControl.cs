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
		}

		private void openButton_Click(object sender, EventArgs e)
		{
			if (Directory.Exists(Path))
			{
				ProcessStartInfo startInfo = new ProcessStartInfo
				{
					Arguments = Path,
					FileName = "explorer.exe"
				};
				Process.Start(startInfo);
			}
			else
			{
				MessageBox.Show("{0}\nDirectory not found.", Path);
			}
		}

		private void browseButton_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				SetPath(folderBrowserDialog.SelectedPath);
			}
		}

		private void SetPath(string path)
		{
			Path = path;
			pathBox.Text = Path;
			SaveSetting();
		}

		private void pathBox_TextChanged(object sender, EventArgs e)
		{
			Path = pathBox.Text;
		}

		public void LoadSetting()
		{
			if (CaptureType == CAPTURE_TYPE.NONE)
			{
				SetPath(Environment.GetFolderPath(folderBrowserDialog.RootFolder));
				return;
			}
			SetPath((string)Properties.Settings.Default[CaptureType.ToString()+"_PATH"]);
		}
		private void SaveSetting()
		{
			if (CaptureType == CAPTURE_TYPE.NONE)
				return;
			Properties.Settings.Default[CaptureType.ToString() + "_PATH"] = Path;
			Properties.Settings.Default.Save();
		}
	}
}
