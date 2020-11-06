using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace screen_capture
{
	public struct POINT
	{
		public Int32 x;
		public Int32 y;
	}
	public struct ICONINFO
	{
		public bool fIcon;
		public Int32 xHotspot;
		public Int32 yHotspot;
		public IntPtr hbmMask;
		public IntPtr hbmColor;
	}
	public struct CURSORINFO
	{
		public Int32 cbSize;
		public Int32 flags;
		public IntPtr hCursor;
		public POINT ptScreenPos;
	}
	abstract class WinMessage
	{
		public const Int32 CURSOR_SHOWING = 0x00000001;

		public const int WM_NCLBUTTONDOWN = 0xa1;
		public const int WM_NCHITTEST = 0x84;
		public const int WM_HOTKEY = 0x312;

		public const int HTCAPTION = 0x2;
		public const int HTLEFT = 10;
		public const int HTRIGHT = 11;
		public const int HTTOP = 12;
		public const int HTTOPLEFT = 13;
		public const int HTTOPRIGHT = 14;
		public const int HTBOTTOM = 15;
		public const int HTBOTTOMLEFT = 16;
		public const int HTBOTTOMRIGHT = 17;
		public static readonly Dictionary<string, int> HITTEST = new Dictionary<string, int>
		{
			{ "top", HTTOP },
			{ "left", HTLEFT },
			{ "right", HTRIGHT },
			{ "bottom", HTBOTTOM },
			{ "topLeft", HTTOPLEFT },
			{ "topRight", HTTOPRIGHT },
			{ "bottomLeft", HTBOTTOMLEFT },
			{ "bottomRight", HTBOTTOMRIGHT }
		};
}
}
