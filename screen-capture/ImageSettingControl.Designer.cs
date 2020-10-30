namespace screen_capture
{
	partial class ImageSettingControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageSettingControl));
			this.settingTitleLabel = new System.Windows.Forms.Label();
			this.detailedSettingPanel = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.numRectLabel = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.numImageRect = new screen_capture.FlatNumericUpDown();
			this.panel3 = new System.Windows.Forms.Panel();
			this.autosaveCheckbox = new System.Windows.Forms.CheckBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.autosaveDetailPanel = new System.Windows.Forms.Panel();
			this.autosavePathLabel = new System.Windows.Forms.Label();
			this.directoryControl1 = new screen_capture.DirectoryControl();
			this.panel5 = new System.Windows.Forms.Panel();
			this.autosaveNamingLabel = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panel6 = new System.Windows.Forms.Panel();
			this.detailedSettingPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.autosaveDetailPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// settingTitleLabel
			// 
			this.settingTitleLabel.AutoSize = true;
			this.settingTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.settingTitleLabel.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.settingTitleLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.settingTitleLabel.Location = new System.Drawing.Point(10, 10);
			this.settingTitleLabel.Name = "settingTitleLabel";
			this.settingTitleLabel.Size = new System.Drawing.Size(164, 30);
			this.settingTitleLabel.TabIndex = 1;
			this.settingTitleLabel.Text = "Image Settings";
			// 
			// detailedSettingPanel
			// 
			this.detailedSettingPanel.BackColor = System.Drawing.Color.Transparent;
			this.detailedSettingPanel.Controls.Add(this.panel2);
			this.detailedSettingPanel.Controls.Add(this.panel1);
			this.detailedSettingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.detailedSettingPanel.Location = new System.Drawing.Point(10, 40);
			this.detailedSettingPanel.Name = "detailedSettingPanel";
			this.detailedSettingPanel.Padding = new System.Windows.Forms.Padding(10, 15, 0, 0);
			this.detailedSettingPanel.Size = new System.Drawing.Size(540, 313);
			this.detailedSettingPanel.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.numRectLabel);
			this.panel1.Controls.Add(this.numImageRect);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(10, 15);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(530, 22);
			this.panel1.TabIndex = 1;
			// 
			// numRectLabel
			// 
			this.numRectLabel.AutoSize = true;
			this.numRectLabel.Dock = System.Windows.Forms.DockStyle.Left;
			this.numRectLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.numRectLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.numRectLabel.Location = new System.Drawing.Point(70, 0);
			this.numRectLabel.Margin = new System.Windows.Forms.Padding(0);
			this.numRectLabel.Name = "numRectLabel";
			this.numRectLabel.Size = new System.Drawing.Size(244, 21);
			this.numRectLabel.TabIndex = 1;
			this.numRectLabel.Text = " Number of Image Capture Box";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.autosaveDetailPanel);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.autosaveCheckbox);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(10, 37);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(530, 276);
			this.panel2.TabIndex = 3;
			// 
			// numImageRect
			// 
			this.numImageRect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(83)))));
			this.numImageRect.Dock = System.Windows.Forms.DockStyle.Left;
			this.numImageRect.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.numImageRect.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.numImageRect.Location = new System.Drawing.Point(0, 0);
			this.numImageRect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.numImageRect.Name = "numImageRect";
			this.numImageRect.Size = new System.Drawing.Size(70, 22);
			this.numImageRect.TabIndex = 0;
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
			this.autosaveCheckbox.Dock = System.Windows.Forms.DockStyle.Top;
			this.autosaveCheckbox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.autosaveCheckbox.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.autosaveCheckbox.Location = new System.Drawing.Point(0, 10);
			this.autosaveCheckbox.Name = "autosaveCheckbox";
			this.autosaveCheckbox.Size = new System.Drawing.Size(530, 25);
			this.autosaveCheckbox.TabIndex = 4;
			this.autosaveCheckbox.Text = "Auto Save";
			this.autosaveCheckbox.UseVisualStyleBackColor = true;
			// 
			// panel4
			// 
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 35);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(530, 10);
			this.panel4.TabIndex = 5;
			// 
			// autosaveDetailPanel
			// 
			this.autosaveDetailPanel.Controls.Add(this.panel6);
			this.autosaveDetailPanel.Controls.Add(this.textBox1);
			this.autosaveDetailPanel.Controls.Add(this.autosaveNamingLabel);
			this.autosaveDetailPanel.Controls.Add(this.panel5);
			this.autosaveDetailPanel.Controls.Add(this.directoryControl1);
			this.autosaveDetailPanel.Controls.Add(this.autosavePathLabel);
			this.autosaveDetailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.autosaveDetailPanel.Location = new System.Drawing.Point(0, 45);
			this.autosaveDetailPanel.Name = "autosaveDetailPanel";
			this.autosaveDetailPanel.Size = new System.Drawing.Size(530, 231);
			this.autosaveDetailPanel.TabIndex = 6;
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
			// directoryControl1
			// 
			this.directoryControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.directoryControl1.Location = new System.Drawing.Point(0, 21);
			this.directoryControl1.Name = "directoryControl1";
			this.directoryControl1.Size = new System.Drawing.Size(530, 22);
			this.directoryControl1.TabIndex = 1;
			// 
			// panel5
			// 
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 43);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(530, 10);
			this.panel5.TabIndex = 6;
			// 
			// autosaveNamingLabel
			// 
			this.autosaveNamingLabel.AutoSize = true;
			this.autosaveNamingLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.autosaveNamingLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.autosaveNamingLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.autosaveNamingLabel.Location = new System.Drawing.Point(0, 53);
			this.autosaveNamingLabel.Name = "autosaveNamingLabel";
			this.autosaveNamingLabel.Size = new System.Drawing.Size(187, 21);
			this.autosaveNamingLabel.TabIndex = 7;
			this.autosaveNamingLabel.Text = "Auto Save Naming Rule";
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBox1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox1.Location = new System.Drawing.Point(0, 74);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(530, 22);
			this.textBox1.TabIndex = 8;
			// 
			// panel6
			// 
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(0, 96);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(530, 10);
			this.panel6.TabIndex = 9;
			// 
			// ImageSettingControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(83)))));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.detailedSettingPanel);
			this.Controls.Add(this.settingTitleLabel);
			this.Name = "ImageSettingControl";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.Size = new System.Drawing.Size(560, 363);
			this.detailedSettingPanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.autosaveDetailPanel.ResumeLayout(false);
			this.autosaveDetailPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label settingTitleLabel;
		private System.Windows.Forms.Panel detailedSettingPanel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label numRectLabel;
		private FlatNumericUpDown numImageRect;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel autosaveDetailPanel;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label autosaveNamingLabel;
		private System.Windows.Forms.Panel panel5;
		private DirectoryControl directoryControl1;
		private System.Windows.Forms.Label autosavePathLabel;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.CheckBox autosaveCheckbox;
		private System.Windows.Forms.Panel panel6;
	}
}
