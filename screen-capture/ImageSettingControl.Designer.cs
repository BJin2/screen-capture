﻿namespace screen_capture
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
			this.contentsContainer = new System.Windows.Forms.Panel();
			this.detailedContentsPanel = new System.Windows.Forms.Panel();
			this.autosaveDetailPanel = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.autosavePathLabel = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.autosaveCheckbox = new System.Windows.Forms.CheckBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.numRectLabel = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.namingRule = new System.Windows.Forms.TextBox();
			this.panel8 = new System.Windows.Forms.Panel();
			this.fileFormatList = new System.Windows.Forms.ComboBox();
			this.fileFormatLabel = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.directoryControl1 = new screen_capture.DirectoryControl();
			this.numImageRect = new screen_capture.FlatNumericUpDown();
			this.panel9 = new System.Windows.Forms.Panel();
			this.panel10 = new System.Windows.Forms.Panel();
			this.oneRecord = new System.Windows.Forms.TextBox();
			this.panel12 = new System.Windows.Forms.Panel();
			this.allRecord = new System.Windows.Forms.TextBox();
			this.oneShortcut = new System.Windows.Forms.CheckBox();
			this.allShortcut = new System.Windows.Forms.CheckBox();
			this.contentsContainer.SuspendLayout();
			this.detailedContentsPanel.SuspendLayout();
			this.autosaveDetailPanel.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel10.SuspendLayout();
			this.panel12.SuspendLayout();
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
			this.contentsContainer.TabIndex = 2;
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
			// autosaveDetailPanel
			// 
			this.autosaveDetailPanel.Controls.Add(this.panel8);
			this.autosaveDetailPanel.Controls.Add(this.panel6);
			this.autosaveDetailPanel.Controls.Add(this.panel2);
			this.autosaveDetailPanel.Controls.Add(this.panel5);
			this.autosaveDetailPanel.Controls.Add(this.directoryControl1);
			this.autosaveDetailPanel.Controls.Add(this.autosavePathLabel);
			this.autosaveDetailPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.autosaveDetailPanel.Location = new System.Drawing.Point(0, 45);
			this.autosaveDetailPanel.Name = "autosaveDetailPanel";
			this.autosaveDetailPanel.Size = new System.Drawing.Size(530, 129);
			this.autosaveDetailPanel.TabIndex = 8;
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
			// 
			// panel3
			// 
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(530, 10);
			this.panel3.TabIndex = 3;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.numImageRect);
			this.panel1.Controls.Add(this.numRectLabel);
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
			this.numRectLabel.Location = new System.Drawing.Point(0, 0);
			this.numRectLabel.Margin = new System.Windows.Forms.Padding(0);
			this.numRectLabel.Name = "numRectLabel";
			this.numRectLabel.Size = new System.Drawing.Size(157, 21);
			this.numRectLabel.TabIndex = 1;
			this.numRectLabel.Text = "Image Capture Box ";
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
			// namingRule
			// 
			this.namingRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.namingRule.Dock = System.Windows.Forms.DockStyle.Left;
			this.namingRule.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.namingRule.Location = new System.Drawing.Point(105, 0);
			this.namingRule.Name = "namingRule";
			this.namingRule.Size = new System.Drawing.Size(396, 22);
			this.namingRule.TabIndex = 1;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.fileFormatList);
			this.panel8.Controls.Add(this.fileFormatLabel);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel8.Location = new System.Drawing.Point(0, 85);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(530, 34);
			this.panel8.TabIndex = 12;
			// 
			// fileFormatList
			// 
			this.fileFormatList.Dock = System.Windows.Forms.DockStyle.Left;
			this.fileFormatList.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.fileFormatList.FormattingEnabled = true;
			this.fileFormatList.Location = new System.Drawing.Point(93, 0);
			this.fileFormatList.Name = "fileFormatList";
			this.fileFormatList.Size = new System.Drawing.Size(105, 29);
			this.fileFormatList.TabIndex = 12;
			// 
			// fileFormatLabel
			// 
			this.fileFormatLabel.AutoSize = true;
			this.fileFormatLabel.Dock = System.Windows.Forms.DockStyle.Left;
			this.fileFormatLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.fileFormatLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.fileFormatLabel.Location = new System.Drawing.Point(0, 0);
			this.fileFormatLabel.Name = "fileFormatLabel";
			this.fileFormatLabel.Size = new System.Drawing.Size(93, 21);
			this.fileFormatLabel.TabIndex = 11;
			this.fileFormatLabel.Text = "File Format";
			// 
			// panel6
			// 
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(0, 75);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(530, 10);
			this.panel6.TabIndex = 11;
			// 
			// directoryControl1
			// 
			this.directoryControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.directoryControl1.Location = new System.Drawing.Point(0, 21);
			this.directoryControl1.Name = "directoryControl1";
			this.directoryControl1.Size = new System.Drawing.Size(530, 22);
			this.directoryControl1.TabIndex = 1;
			// 
			// numImageRect
			// 
			this.numImageRect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(83)))));
			this.numImageRect.Dock = System.Windows.Forms.DockStyle.Left;
			this.numImageRect.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.numImageRect.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.numImageRect.Location = new System.Drawing.Point(157, 0);
			this.numImageRect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.numImageRect.Name = "numImageRect";
			this.numImageRect.Size = new System.Drawing.Size(70, 22);
			this.numImageRect.TabIndex = 2;
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
			this.panel10.Controls.Add(this.oneShortcut);
			this.panel10.Controls.Add(this.oneRecord);
			this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel10.Location = new System.Drawing.Point(0, 174);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(530, 22);
			this.panel10.TabIndex = 12;
			// 
			// oneRecord
			// 
			this.oneRecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.oneRecord.Dock = System.Windows.Forms.DockStyle.Right;
			this.oneRecord.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.oneRecord.Location = new System.Drawing.Point(177, 0);
			this.oneRecord.Name = "oneRecord";
			this.oneRecord.Size = new System.Drawing.Size(353, 22);
			this.oneRecord.TabIndex = 1;
			// 
			// panel12
			// 
			this.panel12.Controls.Add(this.allShortcut);
			this.panel12.Controls.Add(this.allRecord);
			this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel12.Location = new System.Drawing.Point(0, 206);
			this.panel12.Name = "panel12";
			this.panel12.Size = new System.Drawing.Size(530, 22);
			this.panel12.TabIndex = 14;
			// 
			// allRecord
			// 
			this.allRecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.allRecord.Dock = System.Windows.Forms.DockStyle.Right;
			this.allRecord.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.allRecord.Location = new System.Drawing.Point(177, 0);
			this.allRecord.Name = "allRecord";
			this.allRecord.Size = new System.Drawing.Size(353, 22);
			this.allRecord.TabIndex = 1;
			// 
			// oneShortcut
			// 
			this.oneShortcut.AutoSize = true;
			this.oneShortcut.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.oneShortcut.Dock = System.Windows.Forms.DockStyle.Left;
			this.oneShortcut.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.oneShortcut.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.oneShortcut.Location = new System.Drawing.Point(0, 0);
			this.oneShortcut.Name = "oneShortcut";
			this.oneShortcut.Size = new System.Drawing.Size(139, 22);
			this.oneShortcut.TabIndex = 2;
			this.oneShortcut.Text = "Box n Shortcut";
			this.oneShortcut.UseVisualStyleBackColor = true;
			// 
			// allShortcut
			// 
			this.allShortcut.AutoSize = true;
			this.allShortcut.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.allShortcut.Dock = System.Windows.Forms.DockStyle.Left;
			this.allShortcut.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.allShortcut.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.allShortcut.Location = new System.Drawing.Point(0, 0);
			this.allShortcut.Name = "allShortcut";
			this.allShortcut.Size = new System.Drawing.Size(139, 22);
			this.allShortcut.TabIndex = 3;
			this.allShortcut.Text = "1 ~ n Shortcut";
			this.allShortcut.UseVisualStyleBackColor = true;
			// 
			// ImageSettingControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(83)))));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.contentsContainer);
			this.Controls.Add(this.settingTitleLabel);
			this.Name = "ImageSettingControl";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.Size = new System.Drawing.Size(560, 363);
			this.contentsContainer.ResumeLayout(false);
			this.detailedContentsPanel.ResumeLayout(false);
			this.autosaveDetailPanel.ResumeLayout(false);
			this.autosaveDetailPanel.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.panel10.ResumeLayout(false);
			this.panel10.PerformLayout();
			this.panel12.ResumeLayout(false);
			this.panel12.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label settingTitleLabel;
		private System.Windows.Forms.Panel contentsContainer;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label numRectLabel;
		private System.Windows.Forms.Panel detailedContentsPanel;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel autosaveDetailPanel;
		private System.Windows.Forms.Panel panel5;
		private DirectoryControl directoryControl1;
		private System.Windows.Forms.Label autosavePathLabel;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.CheckBox autosaveCheckbox;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.ComboBox fileFormatList;
		private System.Windows.Forms.Label fileFormatLabel;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox namingRule;
		private System.Windows.Forms.Label label1;
		private FlatNumericUpDown numImageRect;
		private System.Windows.Forms.Panel panel12;
		private System.Windows.Forms.CheckBox allShortcut;
		private System.Windows.Forms.TextBox allRecord;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.CheckBox oneShortcut;
		private System.Windows.Forms.TextBox oneRecord;
	}
}
