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

namespace screen_capture
{
	public partial class ShortcutControl : UserControl
	{
		public bool enabled = true;

		public ShortcutControl()
		{
			InitializeComponent();
			shortcutText.KeyDown += shortcutText_Down;
		}

		private void shortcutText_Down(object sender, KeyEventArgs e)
		{
			if (!enabled)
				return;
			Keys k = e.KeyCode;
			int mod = KeysModToMod(e.Modifiers);
			shortcutText.Text = "";

			if ((k != Keys.ControlKey) &&
				(k != Keys.ShiftKey) &&
				(k != Keys.Menu))
			{
				KeysConverter converter = new KeysConverter();
				string modifiers = converter.ConvertToString(e.Modifiers);
				
				shortcutText.Text = modifiers.Replace("None", "") + converter.ConvertToString(k);
			}
		}
		private int KeysModToMod(Keys m)
		{
			int mod = 0;

			if (m == Keys.None)
				return mod;

			if ((Keys.Control & m) == Keys.Control)
			{
				mod = mod | (int)MOD.CTRL;
			}
			if ((Keys.Shift & m) == Keys.Shift)
			{
				mod = mod | (int)MOD.SHIFT;
			}
			if ((Keys.Alt & m) == Keys.Alt)
			{
				mod = mod | (int)MOD.ALT;
			}

			return mod;
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
