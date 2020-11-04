namespace screen_capture
{
	partial class FlatNumericUpDown
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlatNumericUpDown));
			this.numberBox = new System.Windows.Forms.TextBox();
			this.buttonsPanel = new System.Windows.Forms.Panel();
			this.downButton = new System.Windows.Forms.Button();
			this.upButton = new System.Windows.Forms.Button();
			this.buttonsPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// numberBox
			// 
			this.numberBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(83)))), ((int)(((byte)(109)))));
			this.numberBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.numberBox.Dock = System.Windows.Forms.DockStyle.Left;
			this.numberBox.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.numberBox.Location = new System.Drawing.Point(0, 0);
			this.numberBox.Margin = new System.Windows.Forms.Padding(0);
			this.numberBox.MaxLength = 3;
			this.numberBox.Name = "numberBox";
			this.numberBox.Size = new System.Drawing.Size(40, 22);
			this.numberBox.TabIndex = 0;
			this.numberBox.Text = "0";
			this.numberBox.TextChanged += new System.EventHandler(this.numberBox_TextChanged);
			// 
			// buttonsPanel
			// 
			this.buttonsPanel.Controls.Add(this.downButton);
			this.buttonsPanel.Controls.Add(this.upButton);
			this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.buttonsPanel.Location = new System.Drawing.Point(40, 0);
			this.buttonsPanel.Name = "buttonsPanel";
			this.buttonsPanel.Size = new System.Drawing.Size(30, 22);
			this.buttonsPanel.TabIndex = 1;
			// 
			// downButton
			// 
			this.downButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(87)))));
			this.downButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.downButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.downButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.downButton.Image = ((System.Drawing.Image)(resources.GetObject("downButton.Image")));
			this.downButton.Location = new System.Drawing.Point(0, 11);
			this.downButton.Margin = new System.Windows.Forms.Padding(0);
			this.downButton.Name = "downButton";
			this.downButton.Size = new System.Drawing.Size(30, 11);
			this.downButton.TabIndex = 1;
			this.downButton.UseVisualStyleBackColor = false;
			this.downButton.Click += new System.EventHandler(this.downButton_Click);
			// 
			// upButton
			// 
			this.upButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(87)))));
			this.upButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.upButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.upButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.upButton.Image = ((System.Drawing.Image)(resources.GetObject("upButton.Image")));
			this.upButton.Location = new System.Drawing.Point(0, 0);
			this.upButton.Margin = new System.Windows.Forms.Padding(0);
			this.upButton.Name = "upButton";
			this.upButton.Size = new System.Drawing.Size(30, 11);
			this.upButton.TabIndex = 0;
			this.upButton.UseVisualStyleBackColor = false;
			this.upButton.Click += new System.EventHandler(this.upButton_Click);
			// 
			// FlatNumericUpDown
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(83)))));
			this.Controls.Add(this.buttonsPanel);
			this.Controls.Add(this.numberBox);
			this.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FlatNumericUpDown";
			this.Size = new System.Drawing.Size(70, 22);
			this.buttonsPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox numberBox;
		private System.Windows.Forms.Panel buttonsPanel;
		private System.Windows.Forms.Button downButton;
		private System.Windows.Forms.Button upButton;
	}
}
