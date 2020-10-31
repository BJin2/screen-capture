namespace screen_capture
{
	partial class DirectoryControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectoryControl));
			this.pathBox = new System.Windows.Forms.TextBox();
			this.browseButton = new System.Windows.Forms.Button();
			this.openButton = new System.Windows.Forms.Button();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.SuspendLayout();
			// 
			// pathBox
			// 
			this.pathBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.pathBox.Dock = System.Windows.Forms.DockStyle.Left;
			this.pathBox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.pathBox.Location = new System.Drawing.Point(0, 0);
			this.pathBox.Name = "pathBox";
			this.pathBox.Size = new System.Drawing.Size(380, 22);
			this.pathBox.TabIndex = 0;
			this.pathBox.WordWrap = false;
			this.pathBox.TextChanged += new System.EventHandler(this.pathBox_TextChanged);
			// 
			// browseButton
			// 
			this.browseButton.BackColor = System.Drawing.SystemColors.ControlDark;
			this.browseButton.Dock = System.Windows.Forms.DockStyle.Left;
			this.browseButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
			this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.browseButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.browseButton.Image = ((System.Drawing.Image)(resources.GetObject("browseButton.Image")));
			this.browseButton.Location = new System.Drawing.Point(380, 0);
			this.browseButton.Margin = new System.Windows.Forms.Padding(0);
			this.browseButton.Name = "browseButton";
			this.browseButton.Size = new System.Drawing.Size(60, 22);
			this.browseButton.TabIndex = 1;
			this.browseButton.UseVisualStyleBackColor = false;
			this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
			// 
			// openButton
			// 
			this.openButton.BackColor = System.Drawing.SystemColors.ControlDark;
			this.openButton.Dock = System.Windows.Forms.DockStyle.Left;
			this.openButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
			this.openButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.openButton.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.openButton.Image = ((System.Drawing.Image)(resources.GetObject("openButton.Image")));
			this.openButton.Location = new System.Drawing.Point(440, 0);
			this.openButton.Margin = new System.Windows.Forms.Padding(0);
			this.openButton.Name = "openButton";
			this.openButton.Size = new System.Drawing.Size(60, 22);
			this.openButton.TabIndex = 2;
			this.openButton.UseVisualStyleBackColor = false;
			this.openButton.Click += new System.EventHandler(this.openButton_Click);
			// 
			// folderBrowserDialog
			// 
			this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyDocuments;
			// 
			// DirectoryControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.openButton);
			this.Controls.Add(this.browseButton);
			this.Controls.Add(this.pathBox);
			this.Name = "DirectoryControl";
			this.Size = new System.Drawing.Size(500, 22);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox pathBox;
		private System.Windows.Forms.Button browseButton;
		private System.Windows.Forms.Button openButton;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
	}
}
