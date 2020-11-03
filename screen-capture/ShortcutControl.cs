using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shortcut;
using System.Runtime.InteropServices;
using screen_capture.Properties;

namespace screen_capture
{
	public enum SHORTCUT_FUNCTION
	{
		CAPTURE_SELECTION = 1,
		CAPTURE_ALL,
		RECORD_SELECTION,
		RECORD_ALL
	}

	public partial class ShortcutControl : UserControl
	{
		#region winapi imported functions
		[DllImport("user32.dll")]
		private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
		[DllImport("user32.dll")]
		private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
		#endregion

		public SHORTCUT_FUNCTION AssignedFunction { get; set; }
		private bool enabled = true;
		private Hotkey hotkey;

		public ShortcutControl()
		{
			InitializeComponent();
			shortcutText.KeyDown += shortcutText_Down;
			LoadSetting();
		}

		private void shortcutText_Down(object sender, KeyEventArgs e)
		{
			if (!enabled)
				return;

			Keys k = e.KeyCode;

			if ((k != Keys.ControlKey) &&
				(k != Keys.ShiftKey) &&
				(k != Keys.Menu))
			{
				KeysConverter converter = new KeysConverter();

				string modifiers = converter.ConvertToString(e.Modifiers);

				hotkey.MOD = KeysModToMod(e.Modifiers);
				hotkey.KEY = e.KeyValue;
				hotkey.TEXT = modifiers.Replace("None", "") + converter.ConvertToString(k);

				RegisterHotKeyShortcut(hotkey);
			}
		}
		private int KeysModToMod(Keys m)
		{
			int mod = 0;

			if (m == Keys.None)
				return mod;

			if ((Keys.Control & m) == Keys.Control)
			{
				mod |= (int)MOD.CTRL;
			}
			if ((Keys.Shift & m) == Keys.Shift)
			{
				mod |= (int)MOD.SHIFT;
			}
			if ((Keys.Alt & m) == Keys.Alt)
			{
				mod |= (int)MOD.ALT;
			}

			return mod;
		}

		private void RegisterHotKeyShortcut(Hotkey h)
		{
			if (h.KEY == 0)
				return;

			UnregisterHotKey(MainForm.Instance.Handle, (int)AssignedFunction);

			if (!RegisterHotKey(MainForm.Instance.Handle, (int)AssignedFunction, h.MOD, h.KEY))
			{
				MessageBox.Show("Cannot register " + h.TEXT);
				return;
			}
			shortcutText.Text = h.TEXT;
			SaveSetting();
		}

		private void LoadSetting()
		{
			hotkey = new Hotkey(0, 0, "");
			hotkey.MOD = (int)Settings.Default["hotkey_mod"];
			hotkey.KEY = (int)Settings.Default["hotkey_key"];
			hotkey.TEXT = (string)Settings.Default["hotkey_text"];
		}
		private void SaveSetting()
		{
			Settings.Default["hotkey_mod"] = hotkey.MOD;
			Settings.Default["hotkey_key"] = hotkey.KEY;
			Settings.Default["hotkey_text"] = hotkey.TEXT;
			Settings.Default.Save();
		}

		public void Enable()
		{
			enabled = true;
			shortcutText.Enabled = true;
			shortcutText.ForeColor = SystemColors.WindowText;
			//TODO register hotkey
		}
		public void Disable()
		{
			enabled = false;
			shortcutText.Enabled = false;
			shortcutText.ForeColor = SystemColors.ControlDark;
			//TODO unregister hotkey
		}
	}
}
