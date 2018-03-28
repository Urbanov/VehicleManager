namespace VehicleManager
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
			this.MDIMenuStrip = new System.Windows.Forms.MenuStrip();
			this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MDIStatusStrip = new System.Windows.Forms.StatusStrip();
			this.descToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.MDIMenuStrip.SuspendLayout();
			this.MDIStatusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// MDIMenuStrip
			// 
			this.MDIMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem});
			this.MDIMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MDIMenuStrip.Name = "MDIMenuStrip";
			this.MDIMenuStrip.Size = new System.Drawing.Size(784, 24);
			this.MDIMenuStrip.TabIndex = 1;
			this.MDIMenuStrip.Text = "menuStrip1";
			// 
			// newWindowToolStripMenuItem
			// 
			this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
			this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
			this.newWindowToolStripMenuItem.Text = "Open new window";
			this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.newWindowToolStripMenuItem_Click);
			// 
			// MDIStatusStrip
			// 
			this.MDIStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descToolStripStatusLabel});
			this.MDIStatusStrip.Location = new System.Drawing.Point(0, 540);
			this.MDIStatusStrip.Name = "MDIStatusStrip";
			this.MDIStatusStrip.Size = new System.Drawing.Size(784, 22);
			this.MDIStatusStrip.TabIndex = 2;
			this.MDIStatusStrip.Text = "statusStrip1";
			// 
			// descToolStripStatusLabel
			// 
			this.descToolStripStatusLabel.Name = "descToolStripStatusLabel";
			this.descToolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
			this.descToolStripStatusLabel.Text = "items:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.MDIStatusStrip);
			this.Controls.Add(this.MDIMenuStrip);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.MDIMenuStrip;
			this.Name = "MainForm";
			this.Text = "Vehicle Manager";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.MDIMenuStrip.ResumeLayout(false);
			this.MDIMenuStrip.PerformLayout();
			this.MDIStatusStrip.ResumeLayout(false);
			this.MDIStatusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip MDIMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
		public System.Windows.Forms.StatusStrip MDIStatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel descToolStripStatusLabel;
	}
}

