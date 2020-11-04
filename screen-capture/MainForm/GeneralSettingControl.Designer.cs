namespace screen_capture
{
	partial class GeneralSettingControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralSettingControl));
			this.settingTitleLabel = new System.Windows.Forms.Label();
			this.detailedSettingPanel = new System.Windows.Forms.Panel();
			this.topCheckbox = new System.Windows.Forms.CheckBox();
			this.syncCheckbox = new System.Windows.Forms.CheckBox();
			this.detailedSettingPanel.SuspendLayout();
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
			this.settingTitleLabel.Size = new System.Drawing.Size(179, 30);
			this.settingTitleLabel.TabIndex = 0;
			this.settingTitleLabel.Text = "General Settings";
			// 
			// detailedSettingPanel
			// 
			this.detailedSettingPanel.BackColor = System.Drawing.Color.Transparent;
			this.detailedSettingPanel.Controls.Add(this.topCheckbox);
			this.detailedSettingPanel.Controls.Add(this.syncCheckbox);
			this.detailedSettingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.detailedSettingPanel.Location = new System.Drawing.Point(10, 40);
			this.detailedSettingPanel.Name = "detailedSettingPanel";
			this.detailedSettingPanel.Padding = new System.Windows.Forms.Padding(10, 15, 0, 0);
			this.detailedSettingPanel.Size = new System.Drawing.Size(540, 313);
			this.detailedSettingPanel.TabIndex = 1;
			// 
			// topCheckbox
			// 
			this.topCheckbox.AutoSize = true;
			this.topCheckbox.Checked = true;
			this.topCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.topCheckbox.Dock = System.Windows.Forms.DockStyle.Top;
			this.topCheckbox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.topCheckbox.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.topCheckbox.Location = new System.Drawing.Point(10, 40);
			this.topCheckbox.Name = "topCheckbox";
			this.topCheckbox.Size = new System.Drawing.Size(530, 25);
			this.topCheckbox.TabIndex = 1;
			this.topCheckbox.Text = "Always on top (this window)";
			this.topCheckbox.UseVisualStyleBackColor = true;
			this.topCheckbox.CheckedChanged += new System.EventHandler(this.topCheckbox_CheckedChanged);
			// 
			// syncCheckbox
			// 
			this.syncCheckbox.AutoSize = true;
			this.syncCheckbox.Checked = true;
			this.syncCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.syncCheckbox.Dock = System.Windows.Forms.DockStyle.Top;
			this.syncCheckbox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.syncCheckbox.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.syncCheckbox.Location = new System.Drawing.Point(10, 15);
			this.syncCheckbox.Name = "syncCheckbox";
			this.syncCheckbox.Size = new System.Drawing.Size(530, 25);
			this.syncCheckbox.TabIndex = 0;
			this.syncCheckbox.Text = "Sync image and gif auto save settings";
			this.syncCheckbox.UseVisualStyleBackColor = true;
			this.syncCheckbox.CheckedChanged += new System.EventHandler(this.syncCheckbox_CheckedChanged);
			// 
			// GeneralSettingControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(83)))));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.detailedSettingPanel);
			this.Controls.Add(this.settingTitleLabel);
			this.Name = "GeneralSettingControl";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.Size = new System.Drawing.Size(560, 363);
			this.detailedSettingPanel.ResumeLayout(false);
			this.detailedSettingPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label settingTitleLabel;
		private System.Windows.Forms.Panel detailedSettingPanel;
		private System.Windows.Forms.CheckBox topCheckbox;
		private System.Windows.Forms.CheckBox syncCheckbox;
	}
}
