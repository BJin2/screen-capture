namespace screen_capture.GifRect
{
	partial class GifRect
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GifRect));
			this.saveFile = new System.Windows.Forms.SaveFileDialog();
			this.coordY = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.coordX = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pos = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.resHeight = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.resWidth = new System.Windows.Forms.TextBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.res = new System.Windows.Forms.Panel();
			this.clearButton = new System.Windows.Forms.Button();
			this.saveButton = new System.Windows.Forms.Button();
			this.left = new System.Windows.Forms.Panel();
			this.recordButton = new System.Windows.Forms.Button();
			this.textArea = new System.Windows.Forms.Panel();
			this.right = new System.Windows.Forms.Panel();
			this.borderPanel = new System.Windows.Forms.Panel();
			this.recordArea = new System.Windows.Forms.Panel();
			this.recorded = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.top = new System.Windows.Forms.Panel();
			this.topRight = new System.Windows.Forms.Panel();
			this.topLeft = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.bottom = new System.Windows.Forms.Panel();
			this.bottomRight = new System.Windows.Forms.Panel();
			this.bottomLeft = new System.Windows.Forms.Panel();
			this.titlePanel = new System.Windows.Forms.Panel();
			this.limit = new System.Windows.Forms.TextBox();
			this.limitLabel = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.recordImage = new System.Windows.Forms.ImageList(this.components);
			this.panel3.SuspendLayout();
			this.pos.SuspendLayout();
			this.panel4.SuspendLayout();
			this.res.SuspendLayout();
			this.textArea.SuspendLayout();
			this.borderPanel.SuspendLayout();
			this.recordArea.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.recorded)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel5.SuspendLayout();
			this.titlePanel.SuspendLayout();
			this.limitLabel.SuspendLayout();
			this.SuspendLayout();
			// 
			// saveFile
			// 
			this.saveFile.Filter = "Animated Gif|*.gif";
			// 
			// coordY
			// 
			this.coordY.BackColor = System.Drawing.SystemColors.ControlDark;
			this.coordY.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.coordY.Dock = System.Windows.Forms.DockStyle.Right;
			this.coordY.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.coordY.Location = new System.Drawing.Point(131, 2);
			this.coordY.Name = "coordY";
			this.coordY.Size = new System.Drawing.Size(49, 22);
			this.coordY.TabIndex = 3;
			this.coordY.Text = "00000";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.Location = new System.Drawing.Point(114, 2);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(14, 21);
			this.label2.TabIndex = 2;
			this.label2.Text = ",";
			// 
			// coordX
			// 
			this.coordX.BackColor = System.Drawing.SystemColors.ControlDark;
			this.coordX.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.coordX.Dock = System.Windows.Forms.DockStyle.Left;
			this.coordX.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.coordX.Location = new System.Drawing.Point(65, 2);
			this.coordX.Name = "coordX";
			this.coordX.Size = new System.Drawing.Size(49, 22);
			this.coordX.TabIndex = 1;
			this.coordX.Text = "00000";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.Location = new System.Drawing.Point(5, 2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(60, 23);
			this.panel3.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Coord";
			// 
			// pos
			// 
			this.pos.Controls.Add(this.coordY);
			this.pos.Controls.Add(this.label2);
			this.pos.Controls.Add(this.coordX);
			this.pos.Controls.Add(this.panel3);
			this.pos.Dock = System.Windows.Forms.DockStyle.Top;
			this.pos.Location = new System.Drawing.Point(0, 0);
			this.pos.Name = "pos";
			this.pos.Padding = new System.Windows.Forms.Padding(5, 2, 0, 0);
			this.pos.Size = new System.Drawing.Size(180, 25);
			this.pos.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label4.Location = new System.Drawing.Point(0, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 21);
			this.label4.TabIndex = 0;
			this.label4.Text = "Res";
			// 
			// resHeight
			// 
			this.resHeight.BackColor = System.Drawing.SystemColors.ControlDark;
			this.resHeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.resHeight.Dock = System.Windows.Forms.DockStyle.Right;
			this.resHeight.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.resHeight.Location = new System.Drawing.Point(131, 2);
			this.resHeight.Name = "resHeight";
			this.resHeight.Size = new System.Drawing.Size(49, 22);
			this.resHeight.TabIndex = 3;
			this.resHeight.Text = "00000";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label3.Location = new System.Drawing.Point(114, 2);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(17, 21);
			this.label3.TabIndex = 2;
			this.label3.Text = "x";
			// 
			// resWidth
			// 
			this.resWidth.BackColor = System.Drawing.SystemColors.ControlDark;
			this.resWidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.resWidth.Dock = System.Windows.Forms.DockStyle.Left;
			this.resWidth.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.resWidth.Location = new System.Drawing.Point(65, 2);
			this.resWidth.Name = "resWidth";
			this.resWidth.Size = new System.Drawing.Size(49, 22);
			this.resWidth.TabIndex = 1;
			this.resWidth.Text = "00000";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.label4);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel4.Location = new System.Drawing.Point(5, 2);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(60, 23);
			this.panel4.TabIndex = 0;
			// 
			// res
			// 
			this.res.Controls.Add(this.resHeight);
			this.res.Controls.Add(this.label3);
			this.res.Controls.Add(this.resWidth);
			this.res.Controls.Add(this.panel4);
			this.res.Dock = System.Windows.Forms.DockStyle.Top;
			this.res.Location = new System.Drawing.Point(0, 25);
			this.res.Name = "res";
			this.res.Padding = new System.Windows.Forms.Padding(5, 2, 0, 0);
			this.res.Size = new System.Drawing.Size(180, 25);
			this.res.TabIndex = 1;
			// 
			// clearButton
			// 
			this.clearButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.clearButton.FlatAppearance.BorderSize = 0;
			this.clearButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.clearButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
			this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clearButton.Image = ((System.Drawing.Image)(resources.GetObject("clearButton.Image")));
			this.clearButton.Location = new System.Drawing.Point(650, 0);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(50, 50);
			this.clearButton.TabIndex = 3;
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// saveButton
			// 
			this.saveButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.saveButton.FlatAppearance.BorderSize = 0;
			this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
			this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
			this.saveButton.Location = new System.Drawing.Point(700, 0);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(50, 50);
			this.saveButton.TabIndex = 2;
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// left
			// 
			this.left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.left.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.left.Dock = System.Windows.Forms.DockStyle.Left;
			this.left.Location = new System.Drawing.Point(0, 5);
			this.left.Name = "left";
			this.left.Size = new System.Drawing.Size(5, 390);
			this.left.TabIndex = 10;
			// 
			// recordButton
			// 
			this.recordButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.recordButton.FlatAppearance.BorderSize = 0;
			this.recordButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.recordButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
			this.recordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.recordButton.ImageIndex = 0;
			this.recordButton.ImageList = this.recordImage;
			this.recordButton.Location = new System.Drawing.Point(750, 0);
			this.recordButton.Name = "recordButton";
			this.recordButton.Size = new System.Drawing.Size(50, 50);
			this.recordButton.TabIndex = 1;
			this.recordButton.UseVisualStyleBackColor = true;
			this.recordButton.Click += new System.EventHandler(this.recordButton_Click);
			// 
			// textArea
			// 
			this.textArea.Controls.Add(this.res);
			this.textArea.Controls.Add(this.pos);
			this.textArea.Dock = System.Windows.Forms.DockStyle.Left;
			this.textArea.Location = new System.Drawing.Point(0, 0);
			this.textArea.Name = "textArea";
			this.textArea.Size = new System.Drawing.Size(180, 50);
			this.textArea.TabIndex = 0;
			// 
			// right
			// 
			this.right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.right.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.right.Dock = System.Windows.Forms.DockStyle.Right;
			this.right.Location = new System.Drawing.Point(795, 5);
			this.right.Name = "right";
			this.right.Size = new System.Drawing.Size(5, 390);
			this.right.TabIndex = 11;
			// 
			// borderPanel
			// 
			this.borderPanel.Controls.Add(this.recordArea);
			this.borderPanel.Controls.Add(this.right);
			this.borderPanel.Controls.Add(this.left);
			this.borderPanel.Controls.Add(this.panel1);
			this.borderPanel.Controls.Add(this.panel5);
			this.borderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.borderPanel.Location = new System.Drawing.Point(0, 50);
			this.borderPanel.Name = "borderPanel";
			this.borderPanel.Size = new System.Drawing.Size(800, 400);
			this.borderPanel.TabIndex = 3;
			// 
			// recordArea
			// 
			this.recordArea.AutoScroll = true;
			this.recordArea.Controls.Add(this.recorded);
			this.recordArea.Dock = System.Windows.Forms.DockStyle.Fill;
			this.recordArea.Location = new System.Drawing.Point(5, 5);
			this.recordArea.Name = "recordArea";
			this.recordArea.Size = new System.Drawing.Size(790, 390);
			this.recordArea.TabIndex = 13;
			// 
			// recorded
			// 
			this.recorded.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.recorded.Dock = System.Windows.Forms.DockStyle.Fill;
			this.recorded.Location = new System.Drawing.Point(0, 0);
			this.recorded.Name = "recorded";
			this.recorded.Size = new System.Drawing.Size(790, 390);
			this.recorded.TabIndex = 1;
			this.recorded.TabStop = false;
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
			// top
			// 
			this.top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.top.Cursor = System.Windows.Forms.Cursors.SizeNS;
			this.top.Dock = System.Windows.Forms.DockStyle.Fill;
			this.top.Location = new System.Drawing.Point(5, 0);
			this.top.Name = "top";
			this.top.Size = new System.Drawing.Size(790, 5);
			this.top.TabIndex = 2;
			// 
			// topRight
			// 
			this.topRight.BackColor = System.Drawing.Color.Blue;
			this.topRight.Cursor = System.Windows.Forms.Cursors.SizeNESW;
			this.topRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.topRight.Location = new System.Drawing.Point(795, 0);
			this.topRight.Name = "topRight";
			this.topRight.Size = new System.Drawing.Size(5, 5);
			this.topRight.TabIndex = 1;
			// 
			// topLeft
			// 
			this.topLeft.BackColor = System.Drawing.Color.Blue;
			this.topLeft.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
			this.topLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.topLeft.Location = new System.Drawing.Point(0, 0);
			this.topLeft.Name = "topLeft";
			this.topLeft.Size = new System.Drawing.Size(5, 5);
			this.topLeft.TabIndex = 0;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.bottom);
			this.panel5.Controls.Add(this.bottomRight);
			this.panel5.Controls.Add(this.bottomLeft);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel5.Location = new System.Drawing.Point(0, 395);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(800, 5);
			this.panel5.TabIndex = 6;
			// 
			// bottom
			// 
			this.bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.bottom.Cursor = System.Windows.Forms.Cursors.SizeNS;
			this.bottom.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bottom.Location = new System.Drawing.Point(5, 0);
			this.bottom.Name = "bottom";
			this.bottom.Size = new System.Drawing.Size(790, 5);
			this.bottom.TabIndex = 2;
			// 
			// bottomRight
			// 
			this.bottomRight.BackColor = System.Drawing.Color.Blue;
			this.bottomRight.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
			this.bottomRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.bottomRight.Location = new System.Drawing.Point(795, 0);
			this.bottomRight.Name = "bottomRight";
			this.bottomRight.Size = new System.Drawing.Size(5, 5);
			this.bottomRight.TabIndex = 1;
			// 
			// bottomLeft
			// 
			this.bottomLeft.BackColor = System.Drawing.Color.Blue;
			this.bottomLeft.Cursor = System.Windows.Forms.Cursors.SizeNESW;
			this.bottomLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.bottomLeft.Location = new System.Drawing.Point(0, 0);
			this.bottomLeft.Name = "bottomLeft";
			this.bottomLeft.Size = new System.Drawing.Size(5, 5);
			this.bottomLeft.TabIndex = 0;
			// 
			// titlePanel
			// 
			this.titlePanel.BackColor = System.Drawing.SystemColors.ControlDark;
			this.titlePanel.Controls.Add(this.limitLabel);
			this.titlePanel.Controls.Add(this.clearButton);
			this.titlePanel.Controls.Add(this.saveButton);
			this.titlePanel.Controls.Add(this.recordButton);
			this.titlePanel.Controls.Add(this.textArea);
			this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.titlePanel.Location = new System.Drawing.Point(0, 0);
			this.titlePanel.Name = "titlePanel";
			this.titlePanel.Size = new System.Drawing.Size(800, 50);
			this.titlePanel.TabIndex = 2;
			// 
			// limit
			// 
			this.limit.BackColor = System.Drawing.SystemColors.ControlDark;
			this.limit.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.limit.Dock = System.Windows.Forms.DockStyle.Right;
			this.limit.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.limit.Location = new System.Drawing.Point(99, 13);
			this.limit.MaxLength = 3;
			this.limit.Name = "limit";
			this.limit.Size = new System.Drawing.Size(32, 22);
			this.limit.TabIndex = 4;
			this.limit.Text = "100";
			// 
			// limitLabel
			// 
			this.limitLabel.Controls.Add(this.limit);
			this.limitLabel.Controls.Add(this.label5);
			this.limitLabel.Dock = System.Windows.Forms.DockStyle.Right;
			this.limitLabel.Location = new System.Drawing.Point(519, 0);
			this.limitLabel.Name = "limitLabel";
			this.limitLabel.Padding = new System.Windows.Forms.Padding(0, 13, 0, 0);
			this.limitLabel.Size = new System.Drawing.Size(131, 50);
			this.limitLabel.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = System.Windows.Forms.DockStyle.Left;
			this.label5.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label5.Location = new System.Drawing.Point(0, 13);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(102, 21);
			this.label5.TabIndex = 5;
			this.label5.Text = "max length :";
			// 
			// recordImage
			// 
			this.recordImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("recordImage.ImageStream")));
			this.recordImage.TransparentColor = System.Drawing.Color.Transparent;
			this.recordImage.Images.SetKeyName(0, "record.png");
			this.recordImage.Images.SetKeyName(1, "recording.png");
			// 
			// GifRect
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.ControlBox = false;
			this.Controls.Add(this.borderPanel);
			this.Controls.Add(this.titlePanel);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "GifRect";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.pos.ResumeLayout(false);
			this.pos.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.res.ResumeLayout(false);
			this.res.PerformLayout();
			this.textArea.ResumeLayout(false);
			this.borderPanel.ResumeLayout(false);
			this.recordArea.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.recorded)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.titlePanel.ResumeLayout(false);
			this.limitLabel.ResumeLayout(false);
			this.limitLabel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SaveFileDialog saveFile;
		private System.Windows.Forms.TextBox coordY;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox coordX;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel pos;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox resHeight;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox resWidth;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel res;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Panel left;
		private System.Windows.Forms.Button recordButton;
		private System.Windows.Forms.Panel textArea;
		private System.Windows.Forms.Panel right;
		private System.Windows.Forms.Panel borderPanel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel top;
		private System.Windows.Forms.Panel topRight;
		private System.Windows.Forms.Panel topLeft;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel bottom;
		private System.Windows.Forms.Panel bottomRight;
		private System.Windows.Forms.Panel bottomLeft;
		private System.Windows.Forms.Panel titlePanel;
		private System.Windows.Forms.Panel recordArea;
		private System.Windows.Forms.PictureBox recorded;
		private System.Windows.Forms.Panel limitLabel;
		private System.Windows.Forms.TextBox limit;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ImageList recordImage;
	}
}