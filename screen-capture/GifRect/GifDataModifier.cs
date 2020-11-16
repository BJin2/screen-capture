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
	public class GifDataModifier
	{
		//total gif data
		private Data data;
		private bool hasSignature;

		public GifDataModifier()
		{
			data = new Data();
			hasSignature = false;
		}

		public void AddFrame(Bitmap bm, UInt32 delay)
		{
			MemoryStream temp = new MemoryStream();
			bm.Save(temp, ImageFormat.Gif);
			Data gifData = new Data(temp.ToArray());
			Data globalColorTable = ExtractGlobalColorTable(gifData);

			//*/
			if (!hasSignature)
				AddSignature(gifData);

			//Remove other extensions
			RemoveUntilGraphicControlExtension(gifData);

			//Modify gif data to have expected value
			AddDelay(gifData, delay);
			InsertColoTable(gifData, globalColorTable);
			//*/
			MoveFrom(0, gifData.Count, gifData, data);
			if (data.Last() == 0x3b)
				data.RemoveAt(data.Count - 1);
		}

		private void AddSignature(Data oneFrame)
		{
			#region Header
			MoveFrom(0, 6, oneFrame, data);
			#endregion
			#region Screen Descriptor
			byte screenDescriptroPackedByte = oneFrame[4];
			MoveFrom(0, 10, oneFrame, data);
			if (HasColorTable(screenDescriptroPackedByte))
			{
				data[10] ^= 0b10000000;
				int size = GetColorTableSize(screenDescriptroPackedByte) * 3;
				for (int i = 0; i < size; i++)
				{
					oneFrame.RemoveAt(0);
				}
			}
			#endregion
			#region Application Extension
			if (oneFrame[1] == 0x21 && oneFrame[1] == 0xff)
			{
				MoveFrom(0, 19, oneFrame, data);
			}
			#endregion
			hasSignature = true;
		}

		private void AddDelay(Data oneFrame, UInt32 delay)
		{
			oneFrame[4] = (byte)delay;
			oneFrame[5] = (byte)(delay >> 8);
		}

		private void RemoveUntilGraphicControlExtension(Data oneFrame)
		{
			int i;
			for (i = 0; i < oneFrame.Count-1; i++)
			{
				if (oneFrame[i] == 0x21 && oneFrame[i + 1] == 0xf9)
					break;
			}

			if (i != 0)
				oneFrame.RemoveRange(0, i);
		}

		private void InsertColoTable(Data oneFrame, Data colorTable)
		{
			if (HasColorTable(oneFrame[17]))
				return;
			int size = GetColorTableSize(colorTable);
			oneFrame[17] |= 0b10000000;
			oneFrame[17] |= (byte)size;
			oneFrame.InsertRange(18, colorTable);
		}
		public static void MoveFrom(int start, int size, Data from, Data to)
		{
			for (int i = start; i < start + size; i++)
			{
				to.Add(from[i]);
			}
			from.RemoveRange(start, size);
		}

		private Data ExtractGlobalColorTable(Data oneFrame)
		{
			if (!HasColorTable(oneFrame[10]))
				return null;
			Data colorTable = new Data();
			int colorTableSize = GetColorTableSize(oneFrame[10]) * 3;
			for (int i = 0; i < colorTableSize; i++)
			{
				colorTable.Add(oneFrame[13 + i]);
			}
			return colorTable;
		}

		public static bool HasColorTable(byte b)
		{
			return (b & 0b10000000) == 0b10000000;
		}

		public static int GetColorTableSize(byte b)
		{
			//Check last 3 bits of b
			int lastThreePlusOne = (b & 0b00000111) + 1;
			return lastThreePlusOne * lastThreePlusOne;
		}
		public static int GetColorTableSize(Data table)
		{
			int total = table.Count / 3;
			int root = (int)Math.Sqrt(total);
			return root - 1;
		}

		public void Save(string path)
		{
			//data.Add(0x3b);
			FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Read);
			fs.Write(data.ToArray(), 0, data.Count);
			fs.Dispose();
			fs.Close();

			path = path.Replace(".gif", ".txt");
			GifDebugger.ByteListPrinter.PrintByteListToTextFile(path, data);
		}

		public void Clear()
		{
			data.Clear();
			hasSignature = false;
		}

		public void ChangeDelay(Data gif, short delay)
		{
			data = gif;
			/*/
			int i = 13;
			while (i < gif.Count-1)
			{
				//Graphic control exists
				if ((gif[i] == 0x21) && (gif[i+1] == 0xf9))
				{
					gif[i + 4] = (byte)delay;
					gif[i + 5] = (byte)(delay >> 8);
					i += 17;
				}
				else
				{
					while (gif[i] != 0x2c)
					{
						i++;
					}
					i += 9;
				}
				i += (GetColorTableSize(gif[i]) * 3) + 2;

				while (gif[i] != 0x00)
				{
					i += gif[i] + 1;
				}
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
