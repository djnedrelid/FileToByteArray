namespace FileToByteArray
{
	partial class Form1
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
			if (disposing && (components != null)) {
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
			this.btnVelgFile = new System.Windows.Forms.Button();
			this.btnConvertBackToFile = new System.Windows.Forms.Button();
			this.lstFormatValg = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnVelgFile
			// 
			this.btnVelgFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnVelgFile.Location = new System.Drawing.Point(12, 81);
			this.btnVelgFile.Name = "btnVelgFile";
			this.btnVelgFile.Size = new System.Drawing.Size(222, 23);
			this.btnVelgFile.TabIndex = 0;
			this.btnVelgFile.Text = "Convert file to bytes";
			this.btnVelgFile.UseVisualStyleBackColor = true;
			this.btnVelgFile.Click += new System.EventHandler(this.btnVelgFile_Click);
			// 
			// btnConvertBackToFile
			// 
			this.btnConvertBackToFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnConvertBackToFile.Location = new System.Drawing.Point(12, 110);
			this.btnConvertBackToFile.Name = "btnConvertBackToFile";
			this.btnConvertBackToFile.Size = new System.Drawing.Size(222, 23);
			this.btnConvertBackToFile.TabIndex = 1;
			this.btnConvertBackToFile.Text = "Convert bytes to file";
			this.btnConvertBackToFile.UseVisualStyleBackColor = true;
			this.btnConvertBackToFile.Click += new System.EventHandler(this.btnConvertBackToFile_Click);
			// 
			// lstFormatValg
			// 
			this.lstFormatValg.FormattingEnabled = true;
			this.lstFormatValg.Items.AddRange(new object[] {
            "0x90, 0x90",
            "0x90 0x90",
            "90, 90",
            "90 90"});
			this.lstFormatValg.Location = new System.Drawing.Point(12, 12);
			this.lstFormatValg.Name = "lstFormatValg";
			this.lstFormatValg.Size = new System.Drawing.Size(120, 56);
			this.lstFormatValg.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(138, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 26);
			this.label1.TabIndex = 3;
			this.label1.Text = "Velg hvilket format \r\nbytes skal lagres i.";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(246, 145);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lstFormatValg);
			this.Controls.Add(this.btnConvertBackToFile);
			this.Controls.Add(this.btnVelgFile);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "FileToByteArray";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnVelgFile;
		private System.Windows.Forms.Button btnConvertBackToFile;
		private System.Windows.Forms.ListBox lstFormatValg;
		private System.Windows.Forms.Label label1;
	}
}

