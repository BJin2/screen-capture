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
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.numberPanel = new System.Windows.Forms.Panel();
			this.detailedSettingPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.numberPanel.SuspendLayout();
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
			this.detailedSettingPanel.Controls.Add(this.numberPanel);
			this.detailedSettingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.detailedSettingPanel.Location = new System.Drawing.Point(10, 40);
			this.detailedSettingPanel.Name = "detailedSettingPanel";
			this.detailedSettingPanel.Padding = new System.Windows.Forms.Padding(10, 15, 0, 0);
			this.detailedSettingPanel.Size = new System.Drawing.Size(540, 313);
			this.detailedSettingPanel.TabIndex = 2;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(109)))));
			this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.numericUpDown1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.numericUpDown1.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.numericUpDown1.Location = new System.Drawing.Point(0, 0);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(130, 25);
			this.numericUpDown1.TabIndex = 0;
			// 
			// numberPanel
			// 
			this.numberPanel.Controls.Add(this.numericUpDown1);
			this.numberPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.numberPanel.Location = new System.Drawing.Point(10, 15);
			this.numberPanel.Name = "numberPanel";
			this.numberPanel.Padding = new System.Windows.Forms.Padding(0, 0, 400, 0);
			this.numberPanel.Size = new System.Drawing.Size(530, 26);
			this.numberPanel.TabIndex = 1;
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
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.numberPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label settingTitleLabel;
		private System.Windows.Forms.Panel detailedSettingPanel;
		private System.Windows.Forms.Panel numberPanel;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
	}
}
