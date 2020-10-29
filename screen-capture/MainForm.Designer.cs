﻿namespace screen_capture
{
	partial class MainForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.titlePanel = new System.Windows.Forms.Panel();
			this.topGap = new System.Windows.Forms.Panel();
			this.gifRectInfoPanel = new System.Windows.Forms.Panel();
			this.gifRectNumberLabel = new System.Windows.Forms.Label();
			this.gifRectIcon = new System.Windows.Forms.PictureBox();
			this.imageRectInfoPanel = new System.Windows.Forms.Panel();
			this.imageRectNumberLabel = new System.Windows.Forms.Label();
			this.imageRectIcon = new System.Windows.Forms.PictureBox();
			this.foldPanel = new System.Windows.Forms.Panel();
			this.appPanel = new System.Windows.Forms.Panel();
			this.settingPanel = new System.Windows.Forms.Panel();
			this.sideMenuPanel = new System.Windows.Forms.Panel();
			this.bottomGap = new System.Windows.Forms.Panel();
			this.rightGap = new System.Windows.Forms.Panel();
			this.leftGap = new System.Windows.Forms.Panel();
			this.foldButtonPanel = new System.Windows.Forms.Panel();
			this.foldButton = new System.Windows.Forms.Button();
			this.generalButton = new System.Windows.Forms.Button();
			this.imageButton = new System.Windows.Forms.Button();
			this.gifButton = new System.Windows.Forms.Button();
			this.infoButton = new System.Windows.Forms.Button();
			this.logoPanel = new System.Windows.Forms.Panel();
			this.closeButton = new System.Windows.Forms.Button();
			this.minimizeButton = new System.Windows.Forms.Button();
			this.titlePanel.SuspendLayout();
			this.topGap.SuspendLayout();
			this.gifRectInfoPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gifRectIcon)).BeginInit();
			this.imageRectInfoPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imageRectIcon)).BeginInit();
			this.foldPanel.SuspendLayout();
			this.appPanel.SuspendLayout();
			this.sideMenuPanel.SuspendLayout();
			this.foldButtonPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// titlePanel
			// 
			this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
			this.titlePanel.Controls.Add(this.minimizeButton);
			this.titlePanel.Controls.Add(this.closeButton);
			this.titlePanel.Controls.Add(this.logoPanel);
			this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.titlePanel.Location = new System.Drawing.Point(0, 0);
			this.titlePanel.Name = "titlePanel";
			this.titlePanel.Size = new System.Drawing.Size(800, 38);
			this.titlePanel.TabIndex = 0;
			// 
			// topGap
			// 
			this.topGap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(91)))));
			this.topGap.Controls.Add(this.foldButtonPanel);
			this.topGap.Controls.Add(this.gifRectInfoPanel);
			this.topGap.Controls.Add(this.imageRectInfoPanel);
			this.topGap.Dock = System.Windows.Forms.DockStyle.Top;
			this.topGap.Location = new System.Drawing.Point(0, 38);
			this.topGap.Name = "topGap";
			this.topGap.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
			this.topGap.Size = new System.Drawing.Size(800, 30);
			this.topGap.TabIndex = 4;
			// 
			// gifRectInfoPanel
			// 
			this.gifRectInfoPanel.Controls.Add(this.gifRectNumberLabel);
			this.gifRectInfoPanel.Controls.Add(this.gifRectIcon);
			this.gifRectInfoPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.gifRectInfoPanel.Location = new System.Drawing.Point(124, 0);
			this.gifRectInfoPanel.Name = "gifRectInfoPanel";
			this.gifRectInfoPanel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.gifRectInfoPanel.Size = new System.Drawing.Size(200, 30);
			this.gifRectInfoPanel.TabIndex = 1;
			// 
			// gifRectNumberLabel
			// 
			this.gifRectNumberLabel.AutoSize = true;
			this.gifRectNumberLabel.Dock = System.Windows.Forms.DockStyle.Left;
			this.gifRectNumberLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.gifRectNumberLabel.Location = new System.Drawing.Point(30, 5);
			this.gifRectNumberLabel.Name = "gifRectNumberLabel";
			this.gifRectNumberLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.gifRectNumberLabel.Size = new System.Drawing.Size(29, 21);
			this.gifRectNumberLabel.TabIndex = 3;
			this.gifRectNumberLabel.Text = "0";
			// 
			// gifRectIcon
			// 
			this.gifRectIcon.Dock = System.Windows.Forms.DockStyle.Left;
			this.gifRectIcon.Image = ((System.Drawing.Image)(resources.GetObject("gifRectIcon.Image")));
			this.gifRectIcon.Location = new System.Drawing.Point(0, 5);
			this.gifRectIcon.Name = "gifRectIcon";
			this.gifRectIcon.Size = new System.Drawing.Size(30, 20);
			this.gifRectIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.gifRectIcon.TabIndex = 2;
			this.gifRectIcon.TabStop = false;
			// 
			// imageRectInfoPanel
			// 
			this.imageRectInfoPanel.Controls.Add(this.imageRectNumberLabel);
			this.imageRectInfoPanel.Controls.Add(this.imageRectIcon);
			this.imageRectInfoPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.imageRectInfoPanel.Location = new System.Drawing.Point(0, 0);
			this.imageRectInfoPanel.Name = "imageRectInfoPanel";
			this.imageRectInfoPanel.Padding = new System.Windows.Forms.Padding(20, 5, 0, 5);
			this.imageRectInfoPanel.Size = new System.Drawing.Size(124, 30);
			this.imageRectInfoPanel.TabIndex = 0;
			// 
			// imageRectNumberLabel
			// 
			this.imageRectNumberLabel.AutoSize = true;
			this.imageRectNumberLabel.Dock = System.Windows.Forms.DockStyle.Left;
			this.imageRectNumberLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.imageRectNumberLabel.Location = new System.Drawing.Point(50, 5);
			this.imageRectNumberLabel.Name = "imageRectNumberLabel";
			this.imageRectNumberLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.imageRectNumberLabel.Size = new System.Drawing.Size(29, 21);
			this.imageRectNumberLabel.TabIndex = 1;
			this.imageRectNumberLabel.Text = "0";
			// 
			// imageRectIcon
			// 
			this.imageRectIcon.Dock = System.Windows.Forms.DockStyle.Left;
			this.imageRectIcon.Image = ((System.Drawing.Image)(resources.GetObject("imageRectIcon.Image")));
			this.imageRectIcon.Location = new System.Drawing.Point(20, 5);
			this.imageRectIcon.Name = "imageRectIcon";
			this.imageRectIcon.Size = new System.Drawing.Size(30, 20);
			this.imageRectIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imageRectIcon.TabIndex = 0;
			this.imageRectIcon.TabStop = false;
			// 
			// foldPanel
			// 
			this.foldPanel.Controls.Add(this.appPanel);
			this.foldPanel.Controls.Add(this.bottomGap);
			this.foldPanel.Controls.Add(this.rightGap);
			this.foldPanel.Controls.Add(this.leftGap);
			this.foldPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.foldPanel.Location = new System.Drawing.Point(0, 68);
			this.foldPanel.Name = "foldPanel";
			this.foldPanel.Size = new System.Drawing.Size(800, 382);
			this.foldPanel.TabIndex = 5;
			// 
			// appPanel
			// 
			this.appPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(91)))));
			this.appPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.appPanel.Controls.Add(this.settingPanel);
			this.appPanel.Controls.Add(this.sideMenuPanel);
			this.appPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.appPanel.Location = new System.Drawing.Point(18, 0);
			this.appPanel.Name = "appPanel";
			this.appPanel.Size = new System.Drawing.Size(762, 362);
			this.appPanel.TabIndex = 3;
			// 
			// settingPanel
			// 
			this.settingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(83)))));
			this.settingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.settingPanel.Location = new System.Drawing.Point(200, 0);
			this.settingPanel.Name = "settingPanel";
			this.settingPanel.Size = new System.Drawing.Size(560, 360);
			this.settingPanel.TabIndex = 1;
			// 
			// sideMenuPanel
			// 
			this.sideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
			this.sideMenuPanel.Controls.Add(this.infoButton);
			this.sideMenuPanel.Controls.Add(this.gifButton);
			this.sideMenuPanel.Controls.Add(this.imageButton);
			this.sideMenuPanel.Controls.Add(this.generalButton);
			this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.sideMenuPanel.Location = new System.Drawing.Point(0, 0);
			this.sideMenuPanel.Name = "sideMenuPanel";
			this.sideMenuPanel.Size = new System.Drawing.Size(200, 360);
			this.sideMenuPanel.TabIndex = 0;
			// 
			// bottomGap
			// 
			this.bottomGap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(91)))));
			this.bottomGap.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bottomGap.Location = new System.Drawing.Point(18, 362);
			this.bottomGap.Name = "bottomGap";
			this.bottomGap.Size = new System.Drawing.Size(762, 20);
			this.bottomGap.TabIndex = 2;
			// 
			// rightGap
			// 
			this.rightGap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(91)))));
			this.rightGap.Dock = System.Windows.Forms.DockStyle.Right;
			this.rightGap.Location = new System.Drawing.Point(780, 0);
			this.rightGap.Name = "rightGap";
			this.rightGap.Size = new System.Drawing.Size(20, 382);
			this.rightGap.TabIndex = 1;
			// 
			// leftGap
			// 
			this.leftGap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(91)))));
			this.leftGap.Dock = System.Windows.Forms.DockStyle.Left;
			this.leftGap.Location = new System.Drawing.Point(0, 0);
			this.leftGap.Name = "leftGap";
			this.leftGap.Size = new System.Drawing.Size(18, 382);
			this.leftGap.TabIndex = 0;
			// 
			// foldButtonPanel
			// 
			this.foldButtonPanel.Controls.Add(this.foldButton);
			this.foldButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.foldButtonPanel.Location = new System.Drawing.Point(324, 0);
			this.foldButtonPanel.Name = "foldButtonPanel";
			this.foldButtonPanel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.foldButtonPanel.Size = new System.Drawing.Size(456, 30);
			this.foldButtonPanel.TabIndex = 2;
			// 
			// foldButton
			// 
			this.foldButton.BackColor = System.Drawing.Color.Transparent;
			this.foldButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("foldButton.BackgroundImage")));
			this.foldButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.foldButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.foldButton.FlatAppearance.BorderSize = 0;
			this.foldButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.foldButton.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.foldButton.Location = new System.Drawing.Point(419, 5);
			this.foldButton.Name = "foldButton";
			this.foldButton.Size = new System.Drawing.Size(37, 20);
			this.foldButton.TabIndex = 0;
			this.foldButton.UseVisualStyleBackColor = false;
			// 
			// generalButton
			// 
			this.generalButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.generalButton.FlatAppearance.BorderSize = 0;
			this.generalButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(54)))));
			this.generalButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(75)))), ((int)(((byte)(104)))));
			this.generalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.generalButton.Location = new System.Drawing.Point(0, 0);
			this.generalButton.Name = "generalButton";
			this.generalButton.Size = new System.Drawing.Size(200, 50);
			this.generalButton.TabIndex = 0;
			this.generalButton.UseVisualStyleBackColor = true;
			// 
			// imageButton
			// 
			this.imageButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.imageButton.FlatAppearance.BorderSize = 0;
			this.imageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(54)))));
			this.imageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(75)))), ((int)(((byte)(104)))));
			this.imageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.imageButton.Location = new System.Drawing.Point(0, 50);
			this.imageButton.Name = "imageButton";
			this.imageButton.Size = new System.Drawing.Size(200, 50);
			this.imageButton.TabIndex = 1;
			this.imageButton.UseVisualStyleBackColor = true;
			// 
			// gifButton
			// 
			this.gifButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.gifButton.FlatAppearance.BorderSize = 0;
			this.gifButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(54)))));
			this.gifButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(75)))), ((int)(((byte)(104)))));
			this.gifButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gifButton.Location = new System.Drawing.Point(0, 100);
			this.gifButton.Name = "gifButton";
			this.gifButton.Size = new System.Drawing.Size(200, 50);
			this.gifButton.TabIndex = 2;
			this.gifButton.UseVisualStyleBackColor = true;
			// 
			// infoButton
			// 
			this.infoButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.infoButton.FlatAppearance.BorderSize = 0;
			this.infoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(54)))));
			this.infoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(75)))), ((int)(((byte)(104)))));
			this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.infoButton.Location = new System.Drawing.Point(0, 150);
			this.infoButton.Name = "infoButton";
			this.infoButton.Size = new System.Drawing.Size(200, 50);
			this.infoButton.TabIndex = 3;
			this.infoButton.UseVisualStyleBackColor = true;
			// 
			// logoPanel
			// 
			this.logoPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.logoPanel.Location = new System.Drawing.Point(0, 0);
			this.logoPanel.Name = "logoPanel";
			this.logoPanel.Padding = new System.Windows.Forms.Padding(20, 5, 5, 5);
			this.logoPanel.Size = new System.Drawing.Size(324, 38);
			this.logoPanel.TabIndex = 0;
			// 
			// closeButton
			// 
			this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.closeButton.FlatAppearance.BorderSize = 0;
			this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeButton.Location = new System.Drawing.Point(757, 0);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(43, 38);
			this.closeButton.TabIndex = 1;
			this.closeButton.UseVisualStyleBackColor = true;
			// 
			// minimizeButton
			// 
			this.minimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.minimizeButton.FlatAppearance.BorderSize = 0;
			this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.minimizeButton.Location = new System.Drawing.Point(714, 0);
			this.minimizeButton.Name = "minimizeButton";
			this.minimizeButton.Size = new System.Drawing.Size(43, 38);
			this.minimizeButton.TabIndex = 2;
			this.minimizeButton.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.foldPanel);
			this.Controls.Add(this.topGap);
			this.Controls.Add(this.titlePanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.titlePanel.ResumeLayout(false);
			this.topGap.ResumeLayout(false);
			this.gifRectInfoPanel.ResumeLayout(false);
			this.gifRectInfoPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gifRectIcon)).EndInit();
			this.imageRectInfoPanel.ResumeLayout(false);
			this.imageRectInfoPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.imageRectIcon)).EndInit();
			this.foldPanel.ResumeLayout(false);
			this.appPanel.ResumeLayout(false);
			this.sideMenuPanel.ResumeLayout(false);
			this.foldButtonPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel titlePanel;
		private System.Windows.Forms.Panel topGap;
		private System.Windows.Forms.Panel foldPanel;
		private System.Windows.Forms.Panel appPanel;
		private System.Windows.Forms.Panel sideMenuPanel;
		private System.Windows.Forms.Panel bottomGap;
		private System.Windows.Forms.Panel rightGap;
		private System.Windows.Forms.Panel leftGap;
		private System.Windows.Forms.Panel settingPanel;
		private System.Windows.Forms.Panel gifRectInfoPanel;
		private System.Windows.Forms.Label gifRectNumberLabel;
		private System.Windows.Forms.PictureBox gifRectIcon;
		private System.Windows.Forms.Panel imageRectInfoPanel;
		private System.Windows.Forms.Label imageRectNumberLabel;
		private System.Windows.Forms.PictureBox imageRectIcon;
		private System.Windows.Forms.Panel foldButtonPanel;
		private System.Windows.Forms.Button foldButton;
		private System.Windows.Forms.Button infoButton;
		private System.Windows.Forms.Button gifButton;
		private System.Windows.Forms.Button imageButton;
		private System.Windows.Forms.Button generalButton;
		private System.Windows.Forms.Button minimizeButton;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Panel logoPanel;
	}
}

