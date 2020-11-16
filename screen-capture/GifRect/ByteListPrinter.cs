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
			string temp = hex.ToString();
			List<char> c = new List<char>(temp.ToCharArray());
			c.Insert(12, '\n');
			c.Insert(27, '\n');
			for (int i = 0; i < c.Count - 4; i++)
			{
				
				if ((c[i] == '2') && (c[i+1] == '1') && (c[i + 2] == 'f') && (c[i + 3] == '9'))
				{
					c.Insert(i + 16, '\n');
					c.Insert(i + 37, '\n');
				}
			}

			temp = new string(c.ToArray());
			File.WriteAllText(path, temp);
		}
	}
}