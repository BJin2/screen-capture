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
		Hotkey hotkey;

		public ShortcutControl()
		{
			InitializeComponent();
			shortcutText.KeyDown += shortcutText_Down;
			shortcutText.KeyUp += shortcutText_Up;
			hotkey = new Hotkey(-1, -1);
		}

		private void shortcutText_Down(object sender, KeyEventArgs e)
		{
			KeysConverter converter = new KeysConverter();
			MessageBox.Show(converter.ConvertToString(e.Modifiers));
		}
		private void shortcutText_Up(object sender, KeyEventArgs e)
		{
			
		}
	}
}
