namespace screen_capture
{
	partial class ShortcutControl
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
			this.shortcutText = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// shortcutText
			// 
			this.shortcutText.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.shortcutText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.shortcutText.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.shortcutText.Location = new System.Drawing.Point(0, 0);
			this.shortcutText.Name = "shortcutText";
			this.shortcutText.ReadOnly = true;
			this.shortcutText.Size = new System.Drawing.Size(353, 22);
			this.shortcutText.TabIndex = 0;
			// 
			// ShortcutControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.shortcutText);
			this.Name = "ShortcutControl";
			this.Size = new System.Drawing.Size(353, 22);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox shortcutText;
	}
}
