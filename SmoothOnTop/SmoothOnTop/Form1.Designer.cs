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
			this.buttonDoIt = new System.Windows.Forms.Button();
			this.buttonUndoIt = new System.Windows.Forms.Button();
			this.buttonFlashSelected = new System.Windows.Forms.Button();
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
			// buttonDoIt
			// 
			this.buttonDoIt.Location = new System.Drawing.Point(93, 12);
			this.buttonDoIt.Name = "buttonDoIt";
			this.buttonDoIt.Size = new System.Drawing.Size(75, 23);
			this.buttonDoIt.TabIndex = 2;
			this.buttonDoIt.Text = "Do it";
			this.buttonDoIt.UseVisualStyleBackColor = true;
			this.buttonDoIt.Click += new System.EventHandler(this.buttonDoIt_Click);
			// 
			// buttonUndoIt
			// 
			this.buttonUndoIt.Location = new System.Drawing.Point(174, 12);
			this.buttonUndoIt.Name = "buttonUndoIt";
			this.buttonUndoIt.Size = new System.Drawing.Size(75, 23);
			this.buttonUndoIt.TabIndex = 3;
			this.buttonUndoIt.Text = "Undo it";
			this.buttonUndoIt.UseVisualStyleBackColor = true;
			this.buttonUndoIt.Click += new System.EventHandler(this.buttonUndoIt_Click);
			// 
			// buttonFlashSelected
			// 
			this.buttonFlashSelected.Location = new System.Drawing.Point(255, 12);
			this.buttonFlashSelected.Name = "buttonFlashSelected";
			this.buttonFlashSelected.Size = new System.Drawing.Size(89, 23);
			this.buttonFlashSelected.TabIndex = 4;
			this.buttonFlashSelected.Text = "Flash Selected";
			this.buttonFlashSelected.UseVisualStyleBackColor = true;
			this.buttonFlashSelected.Click += new System.EventHandler(this.buttonFlashSelected_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(622, 318);
			this.Controls.Add(this.buttonFlashSelected);
			this.Controls.Add(this.buttonUndoIt);
			this.Controls.Add(this.buttonDoIt);
			this.Controls.Add(this.listBoxWindows);
			this.Controls.Add(this.buttonEnumerate);
			this.Name = "Form1";
			this.Text = "Topmost Maker";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonEnumerate;
		private System.Windows.Forms.ListBox listBoxWindows;
		private System.Windows.Forms.Button buttonDoIt;
		private System.Windows.Forms.Button buttonUndoIt;
		private System.Windows.Forms.Button buttonFlashSelected;
	}
}

