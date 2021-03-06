﻿using System;
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
		NONE,
		CAPTURE_SELECTION,
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

		[DefaultValue(SHORTCUT_FUNCTION.NONE)]
		public SHORTCUT_FUNCTION AssignedFunction { get; set; }
		private bool enabled = true;
		private Hotkey hotkey;

		public ShortcutControl()
		{
			InitializeComponent();
			shortcutText.KeyDown += shortcutText_Down;
		}

		#region Save Load
		public void LoadSetting()
		{
			if (AssignedFunction == SHORTCUT_FUNCTION.NONE)
			{
				//MessageBox.Show("Behavior not selected");
				return;
			}
			string af = AssignedFunction.ToString();
			hotkey = new Hotkey(0, 0, "");
			hotkey.MOD = (int)Settings.Default[af + "_MOD"];
			hotkey.KEY = (int)Settings.Default[af + "_KEY"];
			hotkey.TEXT = (string)Settings.Default[af + "_TEXT"];

			RegisterHotKeyShortcut(hotkey);
		}
		private void SaveSetting()
		{
			if (AssignedFunction == SHORTCUT_FUNCTION.NONE)
			{
				//MessageBox.Show("Behavior not selected");
				return;
			}
			string af = AssignedFunction.ToString();
			Settings.Default[af + "_MOD"] = hotkey.MOD;
			Settings.Default[af + "_KEY"] = hotkey.KEY;
			Settings.Default[af + "_TEXT"] = hotkey.TEXT;
			Settings.Default.Save();
		}
		#endregion

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

		

		public void Enable(bool e)
		{
			enabled = e;
			shortcutText.Enabled = e;
			if (e)
			{
				shortcutText.ForeColor = SystemColors.WindowText;
				RegisterHotKeyShortcut(hotkey);
			}
			else
			{
				shortcutText.ForeColor = SystemColors.ControlDark;
				UnregisterHotKey(MainForm.Instance.Handle, (int)AssignedFunction);
			}
		}
	}
}
