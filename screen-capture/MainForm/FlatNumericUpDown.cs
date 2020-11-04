using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace screen_capture
{
	public partial class FlatNumericUpDown : UserControl
	{
		private int maxValue = 10;
		private int minValue = 0;
		public int NumValue { get; private set; }
		[DefaultValue(SHORTCUT_FUNCTION.NONE)]
		public CAPTURE_TYPE CaptureType { get; set; }

		public FlatNumericUpDown()
		{
			InitializeComponent();
			this.MouseWheel += flatNumericUpDown_Wheel;
			numberBox.KeyPress += new KeyPressEventHandler(numberBox_KeyPress);
		}

		private void numberBox_TextChanged(object sender, EventArgs e)
		{
			if (numberBox.Text == "")
				return;
			NumValue = Clamp(int.Parse(numberBox.Text), minValue, maxValue);
			numberBox.Text = NumValue.ToString();
		}

		private void numberBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void ValueChange(int delta)
		{
			NumValue = Clamp(NumValue + delta, minValue, maxValue);
			numberBox.Text = NumValue.ToString();
			SaveSetting();
		}

		private int Clamp(int val, int min, int max)
		{
			if (val > max)
				return max;
			if (val < min)
				return min;

			return val;
		}

		private void upButton_Click(object sender, EventArgs e)
		{
			ValueChange(1);
		}

		private void downButton_Click(object sender, EventArgs e)
		{
			ValueChange(-1);
		}

		private void flatNumericUpDown_Wheel(object sender, MouseEventArgs e)
		{
			if (e.Delta == 0)
				return;

			ValueChange((e.Delta / Math.Abs(e.Delta)));
		}

		public void LoadSetting()
		{
			if (CaptureType == CAPTURE_TYPE.NONE)
			{
				if (NumValue != 0)
					ValueChange(0);
				return;
			}
			ValueChange((int)Properties.Settings.Default[CaptureType.ToString() + "_NUM_RECT"]);
		}
		private void SaveSetting()
		{
			if (CaptureType == CAPTURE_TYPE.NONE)
				return;
			Properties.Settings.Default[CaptureType.ToString() + "_NUM_RECT"] = NumValue;
			Properties.Settings.Default.Save();
		}
	}
}
