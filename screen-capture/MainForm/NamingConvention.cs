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
using System.Drawing.Imaging;

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

		[DefaultValue(CAPTURE_TYPE.NONE)]
		public CAPTURE_TYPE CaptureType { get; set; }

		public NamingConvention()
		{
			InitializeComponent();
			NamingTemplateIndices = new List<int>();
			addedComboBoxes = new List<ComboBox>();
		}

		#region Combobox
		private ComboBox NewComboBox(int defaultValue = 0)
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
			NamingTemplateIndices.Add(defaultValue);
			c.SelectedIndex = defaultValue;

			return c;
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
		#endregion

		#region Control event handlers
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
				SaveSetting();
				return;
			}
			int index = addedComboBoxes.IndexOf(c);
			NamingTemplateIndices[index] = c.SelectedIndex;
			SaveSetting();
		}
		#endregion

		#region Save & Load Setting
		#region Translate string and int list
		public static List<int> SaveValueToInt(string saveValue)
		{
			List<int> li;
			if (saveValue == "0")
			{
				li = new List<int>
				{
					6, 9, 5, 9, 4, 9, 3, 9, 2, 9, 1, 9, 0
				};
				return li;
			}

			List<string> temp = saveValue.Split(',').ToList();
			li = new List<int>();

			for (int i = 1; i <= int.Parse(temp[0]); i++)
			{
				li.Add(int.Parse(temp[i]));
			}
			return li;
		}
		private string IntToSaveValue(List<int> li)
		{
			string saveValue = li.Count.ToString();

			for (int i = 0; i < li.Count; i++)
			{
				saveValue += "," + li[i].ToString();
			}

			return saveValue;
		}
		#endregion

		private void SaveSetting()
		{
			if (CaptureType == CAPTURE_TYPE.NONE)
				return;
			Properties.Settings.Default[CaptureType.ToString() + "_NAMING"] = IntToSaveValue(NamingTemplateIndices);
			Properties.Settings.Default.Save();
		}
		public void LoadSetting()
		{
			if (CaptureType == CAPTURE_TYPE.NONE)
			{
				return;
			}
			string saveValue = (string)Properties.Settings.Default[CaptureType.ToString() + "_NAMING"];
			List<int> temp = SaveValueToInt(saveValue);
			foreach (int i in temp)
			{
				Controls.Add(NewComboBox(i));
			}
		}
		#endregion

		#region Translate int list to path string
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
			template.Reverse();
			foreach (int i in template)
			{
				name += IndexToString(i, dt);
			}
			template.Reverse();
			return name;
		}
		#endregion
	}
}
