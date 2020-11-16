using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

using Data = System.Collections.Generic.List<byte>;

namespace screen_capture
{
	//Just modify data from GifBitmapEncoder
	public static class GifDataModifier
	{
		private enum Extension
		{
			GraphicControl = 0xf9,
			PlainText = 0x01,
			Application = 0xff,
			Comment = 0xfe
		}

		public static bool HasColorTable(byte b)
		{
			return (b & 0b10000000) == 0b10000000;
		}

		public static int GetColorTableSize(byte b)
		{
			//Check last 3 bits of b
			int lastThreePlusOne = (b & 0b00000111) + 1;
			
			return (int)Math.Pow(2, lastThreePlusOne);
		}

		public static void Save(string path, Data data)
		{
			FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Read);
			fs.Write(data.ToArray(), 0, data.Count);
			fs.Dispose();
			fs.Close();

			//*/
			path = path.Replace(".gif", ".txt");
			GifDebugger.ByteListPrinter.PrintByteListToTextFile(path, data);
			//*/
		}

		public static void ChangeDelay(Data gif, short delay)
		{
			//*/
			int i = 13;
			while (i < gif.Count-1)
			{
				while (gif[i] == 0x21)
				{
					switch ((Extension)gif[i + 1])
					{
						case Extension.GraphicControl:
							gif[i + 4] = (byte)delay;
							gif[i + 5] = (byte)(delay >> 8);
							i += 8;
							break;
						case Extension.Application:
							i += 10;
							break;
						case Extension.PlainText:
							i += gif[i+2] + 1;
							goto case Extension.Comment;
						case Extension.Comment:
							i += 2;
							while (gif[i] != 0x00)
							{
								i += gif[i] + 1;
							}
							break;
						default:
							System.Windows.Forms.MessageBox.Show("Unkown extension found.\nInserting delay failed", "Unkown Extension");
							return;
					}
				}

				if (gif[i] != 0x2c)
				{
					string b = string.Format("{0:x2}", gif[i]);
					System.Windows.Forms.MessageBox.Show("Byte offset incorrect.\nbyte : " + b + "\nindex : " + i.ToString(), "Byte Offset Error");
					return;
				}
				//Skip(image descriptor beginning byte to last byte)
				i += 9;
				int colorTableSize = GetColorTableSize(gif[i]);
				i += (GetColorTableSize(gif[i]) * 3) + 2;//Color table size + lzw minimun code(size of 1 byte) + first code block size indicator(size of 1 byte)

				while (gif[i] != 0x00)
				{
					i += gif[i] + 1;
				}

				//Finished image data loop
				//Adding 1 to start from next frame data
				i += 1;
			}
			/*/
			for (int i = 0; i < gif.Count - 1; i++)
			{
				if ((gif[i] == 0x21) && (gif[i + 1] == 0xf9) && (gif[i+2] == 0x04) && (gif[i+8] == 0x2c))
				{
					gif[i + 4] = (byte)delay;
					gif[i + 5] = (byte)(delay >> 8);
				}
			}
			//*/
		}
	}
}
