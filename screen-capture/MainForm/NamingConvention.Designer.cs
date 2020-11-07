namespace screen_capture
{
	partial class NamingConvention
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
			this.add = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// add
			// 
			this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(160)))));
			this.add.Dock = System.Windows.Forms.DockStyle.Right;
			this.add.FlatAppearance.BorderSize = 0;
			this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.add.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.add.Location = new System.Drawing.Point(263, 0);
			this.add.Name = "add";
			this.add.Size = new System.Drawing.Size(75, 46);
			this.add.TabIndex = 0;
			this.add.Text = "Add";
			this.add.UseVisualStyleBackColor = false;
			this.add.Click += new System.EventHandler(this.add_Click);
			// 
			// NamingConvention
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(104)))), ((int)(((byte)(160)))));
			this.Controls.Add(this.add);
			this.Name = "NamingConvention";
			this.Size = new System.Drawing.Size(338, 46);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button add;
	}
}
