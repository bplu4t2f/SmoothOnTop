namespace SmoothOnTop
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
			this.buttonEnumerate = new System.Windows.Forms.Button();
			this.listBoxWindows = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonEnumerate
			// 
			this.buttonEnumerate.Location = new System.Drawing.Point(12, 12);
			this.buttonEnumerate.Name = "buttonEnumerate";
			this.buttonEnumerate.Size = new System.Drawing.Size(75, 23);
			this.buttonEnumerate.TabIndex = 0;
			this.buttonEnumerate.Text = "Enumerate";
			this.buttonEnumerate.UseVisualStyleBackColor = true;
			this.buttonEnumerate.Click += new System.EventHandler(this.buttonEnumerate_Click);
			// 
			// listBoxWindows
			// 
			this.listBoxWindows.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxWindows.FormattingEnabled = true;
			this.listBoxWindows.Location = new System.Drawing.Point(12, 41);
			this.listBoxWindows.Name = "listBoxWindows";
			this.listBoxWindows.Size = new System.Drawing.Size(598, 251);
			this.listBoxWindows.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(93, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Do it";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(174, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Undo it";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(622, 318);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listBoxWindows);
			this.Controls.Add(this.buttonEnumerate);
			this.Name = "Form1";
			this.Text = "Topmost Maker";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonEnumerate;
		private System.Windows.Forms.ListBox listBoxWindows;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}

