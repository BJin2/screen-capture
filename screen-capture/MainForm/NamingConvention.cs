using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace screen_capture
{
	public partial class NamingConvention : UserControl
	{
		public List<int> NamingTemplateIndices { get; private set; }
		private List<ComboBox> addedComboBoxes;

		private readonly List<string> templates = new List<string>
		{
			"year",
			"month",
			"date",
			"hour",
			"minute",
			"second",
			"milisec",
			"+",
			"-",
			"_",
			"=",
			"/",
			"Remove"
		};

		public NamingConvention()
		{
			InitializeComponent();
			NamingTemplateIndices = new List<int>();
			addedComboBoxes = new List<ComboBox>();
		}

		private ComboBox NewComboBox()
		{
			ComboBox c = new ComboBox();
			foreach (string i in templates)
			{
				c.Items.Add(i);
			}
			c.Dock = DockStyle.Left;
			c.FlatStyle = FlatStyle.Flat;
			c.Font = add.Font;
			c.SelectedIndexChanged += ComboBox_ValueChanged;

			addedComboBoxes.Add(c);
			NamingTemplateIndices.Add(0);
			c.SelectedIndex = 0;

			return c;
		}

		private void add_Click(object sender, EventArgs e)
		{
			Controls.Add(NewComboBox());
		}

		private void ComboBox_ValueChanged(object sender, EventArgs e)
		{
			var c = sender as ComboBox;
			if (templates[c.SelectedIndex] == "Remove")
			{
				RemoveComboBox(c);
				return;
			}
			int index = addedComboBoxes.IndexOf(c);
			NamingTemplateIndices[index] = c.SelectedIndex;

		}

		private void RemoveComboBox(ComboBox c)
		{
			c.SelectedValueChanged -= new EventHandler(ComboBox_ValueChanged);
			int index = addedComboBoxes.IndexOf(c);
			NamingTemplateIndices.RemoveAt(index);
			addedComboBoxes.Remove(c);
			Controls.Remove(c);
			c.Dispose();
		}

		private static string IndexToString(int i, DateTime dt)
		{
			string result = "";
			switch (i)
			{
				case 0://year
					result = dt.ToString("yyyy", DateTimeFormatInfo.InvariantInfo);
					break;
				case 1://month
					result = dt.ToString("MM", DateTimeFormatInfo.InvariantInfo);
					break;
				case 2://date
					result = dt.ToString("dd", DateTimeFormatInfo.InvariantInfo);
					break;
				case 3://hr
					result = dt.ToString("HH", DateTimeFormatInfo.InvariantInfo);
					break;
				case 4://min
					result = dt.ToString("mm", DateTimeFormatInfo.InvariantInfo);
					break;
				case 5://sec
					result = dt.ToString("ss", DateTimeFormatInfo.InvariantInfo);
					break;
				case 6://mili
					result = dt.ToString("ff", DateTimeFormatInfo.InvariantInfo);
					break;
				case 7:
					result = "+";
					break;
				case 8:
					result = "-";
					break;
				case 9:
					result = "_";
					break;
				case 10:
					result = "=";
					break;
				case 11:
					result = "/";
					break;
			}

			return result;
		}

		public static string TemplateToName(List<int> template)
		{
			string name = "";
			DateTime dt = DateTime.Now;
			foreach (int i in template)
			{
				name += IndexToString(i, dt);
			}

			return name;
		}
	}
}
