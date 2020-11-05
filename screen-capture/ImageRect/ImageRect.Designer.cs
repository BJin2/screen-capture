﻿namespace screen_capture.ImageRect
{
	partial class ImageRect
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
			this.panel5 = new System.Windows.Forms.Panel();
			this.bottomLeft = new System.Windows.Forms.Panel();
			this.bottomRight = new System.Windows.Forms.Panel();
			this.bottom = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.topLeft = new System.Windows.Forms.Panel();
			this.topRight = new System.Windows.Forms.Panel();
			this.captureArea = new System.Windows.Forms.Panel();
			this.borderPanel = new System.Windows.Forms.Panel();
			this.titlePanel = new System.Windows.Forms.Panel();
			this.top = new System.Windows.Forms.Panel();
			this.left = new System.Windows.Forms.Panel();
			this.right = new System.Windows.Forms.Panel();
			this.panel5.SuspendLayout();
			this.panel1.SuspendLayout();
			this.borderPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.bottom);
			this.panel5.Controls.Add(this.bottomRight);
			this.panel5.Controls.Add(this.bottomLeft);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel5.Location = new System.Drawing.Point(0, 410);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(800, 5);
			this.panel5.TabIndex = 6;
			// 
			// bottomLeft
			// 
			this.bottomLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.bottomLeft.Cursor = System.Windows.Forms.Cursors.SizeNESW;
			this.bottomLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.bottomLeft.Location = new System.Drawing.Point(0, 0);
			this.bottomLeft.Name = "bottomLeft";
			this.bottomLeft.Size = new System.Drawing.Size(5, 5);
			this.bottomLeft.TabIndex = 0;
			// 
			// bottomRight
			// 
			this.bottomRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.bottomRight.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
			this.bottomRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.bottomRight.Location = new System.Drawing.Point(795, 0);
			this.bottomRight.Name = "bottomRight";
			this.bottomRight.Size = new System.Drawing.Size(5, 5);
			this.bottomRight.TabIndex = 1;
			// 
			// bottom
			// 
			this.bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.bottom.Cursor = System.Windows.Forms.Cursors.SizeNS;
			this.bottom.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bottom.Location = new System.Drawing.Point(5, 0);
			this.bottom.Name = "bottom";
			this.bottom.Size = new System.Drawing.Size(790, 5);
			this.bottom.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.top);
			this.panel1.Controls.Add(this.topRight);
			this.panel1.Controls.Add(this.topLeft);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 5);
			this.panel1.TabIndex = 5;
			// 
			// topLeft
			// 
			this.topLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.topLeft.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
			this.topLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.topLeft.Location = new System.Drawing.Point(0, 0);
			this.topLeft.Name = "topLeft";
			this.topLeft.Size = new System.Drawing.Size(5, 5);
			this.topLeft.TabIndex = 0;
			// 
			// topRight
			// 
			this.topRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.topRight.Cursor = System.Windows.Forms.Cursors.SizeNESW;
			this.topRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.topRight.Location = new System.Drawing.Point(795, 0);
			this.topRight.Name = "topRight";
			this.topRight.Size = new System.Drawing.Size(5, 5);
			this.topRight.TabIndex = 1;
			// 
			// captureArea
			// 
			this.captureArea.Dock = System.Windows.Forms.DockStyle.Fill;
			this.captureArea.Location = new System.Drawing.Point(0, 5);
			this.captureArea.Name = "captureArea";
			this.captureArea.Size = new System.Drawing.Size(800, 405);
			this.captureArea.TabIndex = 9;
			// 
			// borderPanel
			// 
			this.borderPanel.Controls.Add(this.right);
			this.borderPanel.Controls.Add(this.left);
			this.borderPanel.Controls.Add(this.captureArea);
			this.borderPanel.Controls.Add(this.panel1);
			this.borderPanel.Controls.Add(this.panel5);
			this.borderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.borderPanel.Location = new System.Drawing.Point(0, 35);
			this.borderPanel.Name = "borderPanel";
			this.borderPanel.Size = new System.Drawing.Size(800, 415);
			this.borderPanel.TabIndex = 1;
			// 
			// titlePanel
			// 
			this.titlePanel.BackColor = System.Drawing.SystemColors.ControlDark;
			this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.titlePanel.Location = new System.Drawing.Point(0, 0);
			this.titlePanel.Name = "titlePanel";
			this.titlePanel.Size = new System.Drawing.Size(800, 35);
			this.titlePanel.TabIndex = 0;
			// 
			// top
			// 
			this.top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.top.Cursor = System.Windows.Forms.Cursors.SizeNS;
			this.top.Dock = System.Windows.Forms.DockStyle.Fill;
			this.top.Location = new System.Drawing.Point(5, 0);
			this.top.Name = "top";
			this.top.Size = new System.Drawing.Size(790, 5);
			this.top.TabIndex = 2;
			// 
			// left
			// 
			this.left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.left.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.left.Dock = System.Windows.Forms.DockStyle.Left;
			this.left.Location = new System.Drawing.Point(0, 5);
			this.left.Name = "left";
			this.left.Size = new System.Drawing.Size(5, 405);
			this.left.TabIndex = 10;
			// 
			// right
			// 
			this.right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.right.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.right.Dock = System.Windows.Forms.DockStyle.Right;
			this.right.Location = new System.Drawing.Point(795, 5);
			this.right.Name = "right";
			this.right.Size = new System.Drawing.Size(5, 405);
			this.right.TabIndex = 11;
			// 
			// ImageRect
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.ControlBox = false;
			this.Controls.Add(this.borderPanel);
			this.Controls.Add(this.titlePanel);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ImageRect";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.TopMost = true;
			this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.panel5.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.borderPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel bottom;
		private System.Windows.Forms.Panel bottomRight;
		private System.Windows.Forms.Panel bottomLeft;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel topRight;
		private System.Windows.Forms.Panel topLeft;
		private System.Windows.Forms.Panel captureArea;
		private System.Windows.Forms.Panel borderPanel;
		private System.Windows.Forms.Panel top;
		private System.Windows.Forms.Panel right;
		private System.Windows.Forms.Panel left;
		private System.Windows.Forms.Panel titlePanel;
	}
}