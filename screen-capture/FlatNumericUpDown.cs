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

		public FlatNumericUpDown()
		{
			InitializeComponent();
			numberBox.KeyPress += new KeyPressEventHandler(numberBox_KeyPress);
			//TODO load form setting data
			NumValue = minValue;
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
			NumValue = Clamp(NumValue + 1, minValue, maxValue);
			numberBox.Text = NumValue.ToString();
		}

		private void downButton_Click(object sender, EventArgs e)
		{
			NumValue = Clamp(NumValue - 1, minValue, maxValue);
			numberBox.Text = NumValue.ToString();
		}
	}
}
