namespace screen_capture
{
	partial class GifSettingControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GifSettingControl));
			this.numRectLabel = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.numGifRect = new screen_capture.FlatNumericUpDown();
			this.panel3 = new System.Windows.Forms.Panel();
			this.autosaveCheckbox = new System.Windows.Forms.CheckBox();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.autosavePathLabel = new System.Windows.Forms.Label();
			this.namingRule = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.qualityList = new System.Windows.Forms.ComboBox();
			this.panel6 = new System.Windows.Forms.Panel();
			this.gifQualityLabel = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.autosaveDetailPanel = new System.Windows.Forms.Panel();
			this.path = new screen_capture.DirectoryControl();
			this.enableSelectShortcut = new System.Windows.Forms.CheckBox();
			this.panel9 = new System.Windows.Forms.Panel();
			this.panel10 = new System.Windows.Forms.Panel();
			this.selectShortcut = new screen_capture.ShortcutControl();
			this.enableAllShortcut = new System.Windows.Forms.CheckBox();
			this.panel12 = new System.Windows.Forms.Panel();
			this.allShortcut = new screen_capture.ShortcutControl();
			this.detailedContentsPanel = new System.Windows.Forms.Panel();
			this.contentsContainer = new System.Windows.Forms.Panel();
			this.settingTitleLabel = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel8.SuspendLayout();
			this.autosaveDetailPanel.SuspendLayout();
			this.panel10.SuspendLayout();
			this.panel12.SuspendLayout();
			this.detailedContentsPanel.SuspendLayout();
			this.contentsContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// numRectLabel
			// 
			this.numRectLabel.AutoSize = true;
			this.numRectLabel.Dock = System.Windows.Forms.DockStyle.Left;
			this.numRectLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.numRectLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.numRectLabel.Location = new System.Drawing.Point(0, 0);
			this.numRectLabel.Margin = new System.Windows.Forms.Padding(0);
			this.numRectLabel.Name = "numRectLabel";
			this.numRectLabel.Size = new System.Drawing.Size(127, 21);
			this.numRectLabel.TabIndex = 1;
			this.numRectLabel.Text = "Gif Record Box ";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.numGifRect);
			this.panel1.Controls.Add(this.numRectLabel);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(10, 15);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(530, 22);
			this.panel1.TabIndex = 1;
			// 
			// numGifRect
			// 
			this.numGifRect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(83)))));
			this.numGifRect.CaptureType = screen_capture.CAPTURE_TYPE.GIF;
			this.numGifRect.Dock = System.Windows.Forms.DockStyle.Left;
			this.numGifRect.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.numGifRect.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.numGifRect.Location = new System.Drawing.Point(127, 0);
			this.numGifRect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.numGifRect.Name = "numGifRect";
			this.numGifRect.Size = new System.Drawing.Size(70, 22);
			this.numGifRect.TabIndex = 2;
			// 
			// panel3
			// 
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(530, 10);
			this.panel3.TabIndex = 3;
			// 
			// autosaveCheckbox
			// 
			this.autosaveCheckbox.AutoSize = true;
			this.autosaveCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.autosaveCheckbox.Checked = true;
			this.autosaveCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.autosaveCheckbox.Dock = System.Windows.Forms.DockStyle.Left;
			this.autosaveCheckbox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.autosaveCheckbox.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.autosaveCheckbox.Location = new System.Drawing.Point(0, 0);
			this.autosaveCheckbox.Name = "autosaveCheckbox";
			this.autosaveCheckbox.Size = new System.Drawing.Size(105, 25);
			this.autosaveCheckbox.TabIndex = 0;
			this.autosaveCheckbox.Text = "Auto Save";
			this.autosaveCheckbox.UseVisualStyleBackColor = true;
			this.autosaveCheckbox.CheckedChanged += new System.EventHandler(this.autosaveCheckbox_CheckedChanged);
			// 
			// panel7
			// 
			this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel7.Location = new System.Drawing.Point(0, 35);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(530, 10);
			this.panel7.TabIndex = 7;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.autosaveCheckbox);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 10);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(530, 25);
			this.panel4.TabIndex = 4;
			// 
			// panel5
			// 
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 43);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(530, 10);
			this.panel5.TabIndex = 6;
			// 
			// autosavePathLabel
			// 
			this.autosavePathLabel.AutoSize = true;
			this.autosavePathLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.autosavePathLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.autosavePathLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.autosavePathLabel.Location = new System.Drawing.Point(0, 0);
			this.autosavePathLabel.Name = "autosavePathLabel";
			this.autosavePathLabel.Size = new System.Drawing.Size(160, 21);
			this.autosavePathLabel.TabIndex = 0;
			this.autosavePathLabel.Text = "Auto Save Directory";
			// 
			// namingRule
			// 
			this.namingRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.namingRule.Dock = System.Windows.Forms.DockStyle.Left;
			this.namingRule.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.namingRule.Location = new System.Drawing.Point(105, 0);
			this.namingRule.Name = "namingRule";
			this.namingRule.Size = new System.Drawing.Size(396, 22);
			this.namingRule.TabIndex = 1;
			this.namingRule.TextChanged += new System.EventHandler(this.namingRule_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Left;
			this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Naming Rule";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.namingRule);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 53);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(530, 22);
			this.panel2.TabIndex = 7;
			// 
			// qualityList
			// 
			this.qualityList.Dock = System.Windows.Forms.DockStyle.Left;
			this.qualityList.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.qualityList.FormattingEnabled = true;
			this.qualityList.Items.AddRange(new object[] {
            "100%",
            "75%",
            "50%",
            "25%"});
			this.qualityList.Location = new System.Drawing.Point(87, 0);
			this.qualityList.Name = "qualityList";
			this.qualityList.Size = new System.Drawing.Size(105, 29);
			this.qualityList.TabIndex = 12;
			this.qualityList.SelectedIndexChanged += new System.EventHandler(this.qualityList_SelectedIndexChanged);
			// 
			// panel6
			// 
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(0, 75);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(530, 10);
			this.panel6.TabIndex = 11;
			// 
			// gifQualityLabel
			// 
			this.gifQualityLabel.AutoSize = true;
			this.gifQualityLabel.Dock = System.Windows.Forms.DockStyle.Left;
			this.gifQualityLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.gifQualityLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.gifQualityLabel.Location = new System.Drawing.Point(0, 0);
			this.gifQualityLabel.Name = "gifQualityLabel";
			this.gifQualityLabel.Size = new System.Drawing.Size(87, 21);
			this.gifQualityLabel.TabIndex = 11;
			this.gifQualityLabel.Text = "Gif Quality";
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.qualityList);
			this.panel8.Controls.Add(this.gifQualityLabel);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel8.Location = new System.Drawing.Point(0, 85);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(530, 34);
			this.panel8.TabIndex = 12;
			// 
			// autosaveDetailPanel
			// 
			this.autosaveDetailPanel.Controls.Add(this.panel8);
			this.autosaveDetailPanel.Controls.Add(this.panel6);
			this.autosaveDetailPanel.Controls.Add(this.panel2);
			this.autosaveDetailPanel.Controls.Add(this.panel5);
			this.autosaveDetailPanel.Controls.Add(this.path);
			this.autosaveDetailPanel.Controls.Add(this.autosavePathLabel);
			this.autosaveDetailPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.autosaveDetailPanel.Location = new System.Drawing.Point(0, 45);
			this.autosaveDetailPanel.Name = "autosaveDetailPanel";
			this.autosaveDetailPanel.Size = new System.Drawing.Size(530, 129);
			this.autosaveDetailPanel.TabIndex = 8;
			// 
			// path
			// 
			this.path.CaptureType = screen_capture.CAPTURE_TYPE.GIF;
			this.path.Dock = System.Windows.Forms.DockStyle.Top;
			this.path.Location = new System.Drawing.Point(0, 21);
			this.path.Name = "path";
			this.path.Size = new System.Drawing.Size(530, 22);
			this.path.TabIndex = 1;
			// 
			// enableSelectShortcut
			// 
			this.enableSelectShortcut.AutoSize = true;
			this.enableSelectShortcut.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.enableSelectShortcut.Dock = System.Windows.Forms.DockStyle.Left;
			this.enableSelectShortcut.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.enableSelectShortcut.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.enableSelectShortcut.Location = new System.Drawing.Point(0, 0);
			this.enableSelectShortcut.Name = "enableSelectShortcut";
			this.enableSelectShortcut.Size = new System.Drawing.Size(129, 22);
			this.enableSelectShortcut.TabIndex = 2;
			this.enableSelectShortcut.Text = "Box Selection";
			this.enableSelectShortcut.UseVisualStyleBackColor = true;
			this.enableSelectShortcut.CheckedChanged += new System.EventHandler(this.enableSelectShortcut_CheckedChanged);
			// 
			// panel9
			// 
			this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel9.Location = new System.Drawing.Point(0, 196);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(530, 10);
			this.panel9.TabIndex = 13;
			// 
			// panel10
			// 
			this.panel10.Controls.Add(this.selectShortcut);
			this.panel10.Controls.Add(this.enableSelectShortcut);
			this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel10.Location = new System.Drawing.Point(0, 174);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(530, 22);
			this.panel10.TabIndex = 12;
			// 
			// selectShortcut
			// 
			this.selectShortcut.AssignedFunction = screen_capture.SHORTCUT_FUNCTION.RECORD_SELECTION;
			this.selectShortcut.Dock = System.Windows.Forms.DockStyle.Right;
			this.selectShortcut.Location = new System.Drawing.Point(177, 0);
			this.selectShortcut.Name = "selectShortcut";
			this.selectShortcut.Size = new System.Drawing.Size(353, 22);
			this.selectShortcut.TabIndex = 3;
			// 
			// enableAllShortcut
			// 
			this.enableAllShortcut.AutoSize = true;
			this.enableAllShortcut.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.enableAllShortcut.Dock = System.Windows.Forms.DockStyle.Left;
			this.enableAllShortcut.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.enableAllShortcut.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.enableAllShortcut.Location = new System.Drawing.Point(0, 0);
			this.enableAllShortcut.Name = "enableAllShortcut";
			this.enableAllShortcut.Size = new System.Drawing.Size(96, 22);
			this.enableAllShortcut.TabIndex = 3;
			this.enableAllShortcut.Text = "All Boxes";
			this.enableAllShortcut.UseVisualStyleBackColor = true;
			this.enableAllShortcut.CheckedChanged += new System.EventHandler(this.enableAllShortcut_CheckedChanged);
			// 
			// panel12
			// 
			this.panel12.Controls.Add(this.allShortcut);
			this.panel12.Controls.Add(this.enableAllShortcut);
			this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel12.Location = new System.Drawing.Point(0, 206);
			this.panel12.Name = "panel12";
			this.panel12.Size = new System.Drawing.Size(530, 22);
			this.panel12.TabIndex = 14;
			// 
			// allShortcut
			// 
			this.allShortcut.AssignedFunction = screen_capture.SHORTCUT_FUNCTION.RECORD_ALL;
			this.allShortcut.Dock = System.Windows.Forms.DockStyle.Right;
			this.allShortcut.Location = new System.Drawing.Point(177, 0);
			this.allShortcut.Name = "allShortcut";
			this.allShortcut.Size = new System.Drawing.Size(353, 22);
			this.allShortcut.TabIndex = 4;
			// 
			// detailedContentsPanel
			// 
			this.detailedContentsPanel.Controls.Add(this.panel12);
			this.detailedContentsPanel.Controls.Add(this.panel9);
			this.detailedContentsPanel.Controls.Add(this.panel10);
			this.detailedContentsPanel.Controls.Add(this.autosaveDetailPanel);
			this.detailedContentsPanel.Controls.Add(this.panel7);
			this.detailedContentsPanel.Controls.Add(this.panel4);
			this.detailedContentsPanel.Controls.Add(this.panel3);
			this.detailedContentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.detailedContentsPanel.Location = new System.Drawing.Point(10, 37);
			this.detailedContentsPanel.Name = "detailedContentsPanel";
			this.detailedContentsPanel.Size = new System.Drawing.Size(530, 276);
			this.detailedContentsPanel.TabIndex = 3;
			// 
			// contentsContainer
			// 
			this.contentsContainer.BackColor = System.Drawing.Color.Transparent;
			this.contentsContainer.Controls.Add(this.detailedContentsPanel);
			this.contentsContainer.Controls.Add(this.panel1);
			this.contentsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.contentsContainer.Location = new System.Drawing.Point(10, 40);
			this.contentsContainer.Name = "contentsContainer";
			this.contentsContainer.Padding = new System.Windows.Forms.Padding(10, 15, 0, 0);
			this.contentsContainer.Size = new System.Drawing.Size(540, 313);
			this.contentsContainer.TabIndex = 4;
			// 
			// settingTitleLabel
			// 
			this.settingTitleLabel.AutoSize = true;
			this.settingTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.settingTitleLabel.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.settingTitleLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.settingTitleLabel.Location = new System.Drawing.Point(10, 10);
			this.settingTitleLabel.Name = "settingTitleLabel";
			this.settingTitleLabel.Size = new System.Drawing.Size(131, 30);
			this.settingTitleLabel.TabIndex = 3;
			this.settingTitleLabel.Text = "Gif Settings";
			// 
			// GifSettingControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(83)))));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.contentsContainer);
			this.Controls.Add(this.settingTitleLabel);
			this.Name = "GifSettingControl";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.Size = new System.Drawing.Size(560, 363);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.autosaveDetailPanel.ResumeLayout(false);
			this.autosaveDetailPanel.PerformLayout();
			this.panel10.ResumeLayout(false);
			this.panel10.PerformLayout();
			this.panel12.ResumeLayout(false);
			this.panel12.PerformLayout();
			this.detailedContentsPanel.ResumeLayout(false);
			this.contentsContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label numRectLabel;
		private System.Windows.Forms.Panel panel1;
		private FlatNumericUpDown numGifRect;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.CheckBox autosaveCheckbox;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private DirectoryControl path;
		private System.Windows.Forms.Label autosavePathLabel;
		private System.Windows.Forms.TextBox namingRule;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ComboBox qualityList;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label gifQualityLabel;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel autosaveDetailPanel;
		private ShortcutControl selectShortcut;
		private System.Windows.Forms.CheckBox enableSelectShortcut;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Panel panel10;
		private ShortcutControl allShortcut;
		private System.Windows.Forms.CheckBox enableAllShortcut;
		private System.Windows.Forms.Panel panel12;
		private System.Windows.Forms.Panel detailedContentsPanel;
		private System.Windows.Forms.Panel contentsContainer;
		private System.Windows.Forms.Label settingTitleLabel;
	}
}
