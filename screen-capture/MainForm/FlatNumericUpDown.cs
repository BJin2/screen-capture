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
		public event EventHandler<NumberChangeEventArgs> ValueChanged;
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
			if (numberBox.Text == "" || !numberBox.Enabled)
				return;
			SetValue(int.Parse(numberBox.Text));
		}

		private void numberBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}


		private void SetValue(int v)
		{
			NumValue = Clamp(v, minValue, maxValue);
			numberBox.Enabled = false;
			numberBox.Text = NumValue.ToString();
			numberBox.Enabled = true;
			SaveSetting();
			EventArgs args = new EventArgs();
			ValueChanged?.Invoke(this, new NumberChangeEventArgs(NumValue, CaptureType));
		}
		private void ChangeValue(int delta)
		{
			SetValue(NumValue + delta);
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
			ChangeValue(1);
		}

		private void downButton_Click(object sender, EventArgs e)
		{
			ChangeValue(-1);
		}

		private void flatNumericUpDown_Wheel(object sender, MouseEventArgs e)
		{
			if (e.Delta == 0)
				return;

			ChangeValue((e.Delta / Math.Abs(e.Delta)));
		}

		public void LoadSetting()
		{
			if (CaptureType == CAPTURE_TYPE.NONE)
			{
				if (NumValue != 0)
					ChangeValue(0);
				return;
			}
			ChangeValue((int)Properties.Settings.Default[CaptureType.ToString() + "_NUM_RECT"]);
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
