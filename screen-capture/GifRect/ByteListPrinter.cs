using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace GifDebugger
{
	public static class ByteListPrinter
	{
		public static void PrintByteListToTextFile(string path, List<byte> data)
		{
			StringBuilder hex = new StringBuilder(data.Count * 2);
			foreach (byte b in data)
			{
				hex.AppendFormat("{0:x2}", b);
			}
			File.WriteAllText(path, hex.ToString());
		}
	}
}