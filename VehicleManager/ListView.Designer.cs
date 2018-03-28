namespace VehicleManager
{
	partial class ListView
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
			this.vehicleListView = new System.Windows.Forms.ListView();
			this.columnMake = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnSpeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.countToolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.filterMenuStrip = new System.Windows.Forms.MenuStrip();
			this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.slowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.filterMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// vehicleListView
			// 
			this.vehicleListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
			this.vehicleListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMake,
            this.columnSpeed,
            this.columnDate,
            this.columnType});
			this.vehicleListView.ContextMenuStrip = this.contextMenuStrip;
			this.vehicleListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vehicleListView.FullRowSelect = true;
			this.vehicleListView.GridLines = true;
			this.vehicleListView.Location = new System.Drawing.Point(0, 0);
			this.vehicleListView.Name = "vehicleListView";
			this.vehicleListView.Size = new System.Drawing.Size(326, 191);
			this.vehicleListView.TabIndex = 0;
			this.vehicleListView.UseCompatibleStateImageBehavior = false;
			this.vehicleListView.View = System.Windows.Forms.View.Details;
			// 
			// columnMake
			// 
			this.columnMake.Text = "Make";
			this.columnMake.Width = 80;
			// 
			// columnSpeed
			// 
			this.columnSpeed.Text = "Top Speed";
			this.columnSpeed.Width = 80;
			// 
			// columnDate
			// 
			this.columnDate.Text = "Date";
			this.columnDate.Width = 80;
			// 
			// columnType
			// 
			this.columnType.Text = "Type";
			this.columnType.Width = 80;
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(153, 92);
			this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.addToolStripMenuItem.Text = "Add";
			this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.editToolStripMenuItem.Text = "Edit";
			this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
			// 
			// removeToolStripMenuItem
			// 
			this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
			this.removeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.removeToolStripMenuItem.Text = "Remove";
			this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countToolStripStatus});
			this.statusStrip.Location = new System.Drawing.Point(0, 240);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(426, 22);
			this.statusStrip.TabIndex = 1;
			this.statusStrip.Text = "statusStrip";
			this.statusStrip.Visible = false;
			// 
			// countToolStripStatus
			// 
			this.countToolStripStatus.Name = "countToolStripStatus";
			this.countToolStripStatus.Size = new System.Drawing.Size(13, 17);
			this.countToolStripStatus.Text = "0";
			// 
			// filterMenuStrip
			// 
			this.filterMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterToolStripMenuItem});
			this.filterMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.filterMenuStrip.Name = "filterMenuStrip";
			this.filterMenuStrip.Size = new System.Drawing.Size(426, 24);
			this.filterMenuStrip.TabIndex = 2;
			this.filterMenuStrip.Text = "menuStrip1";
			this.filterMenuStrip.Visible = false;
			// 
			// filterToolStripMenuItem
			// 
			this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem,
            this.fastToolStripMenuItem,
            this.slowToolStripMenuItem});
			this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
			this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
			this.filterToolStripMenuItem.Text = "Filter";
			// 
			// allToolStripMenuItem
			// 
			this.allToolStripMenuItem.Name = "allToolStripMenuItem";
			this.allToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.allToolStripMenuItem.Text = "All";
			this.allToolStripMenuItem.Click += new System.EventHandler(this.filterToolStripMenuItem_Click);
			// 
			// fastToolStripMenuItem
			// 
			this.fastToolStripMenuItem.Name = "fastToolStripMenuItem";
			this.fastToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.fastToolStripMenuItem.Text = ">= 100 kph";
			this.fastToolStripMenuItem.Click += new System.EventHandler(this.filterToolStripMenuItem_Click);
			// 
			// slowToolStripMenuItem
			// 
			this.slowToolStripMenuItem.Name = "slowToolStripMenuItem";
			this.slowToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.slowToolStripMenuItem.Text = "< 100 kph";
			this.slowToolStripMenuItem.Click += new System.EventHandler(this.filterToolStripMenuItem_Click);
			// 
			// ListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(326, 191);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.filterMenuStrip);
			this.Controls.Add(this.vehicleListView);
			this.MainMenuStrip = this.filterMenuStrip;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ListView";
			this.Text = "Vehicles";
			this.Activated += new System.EventHandler(this.ListView_Activated);
			this.Deactivate += new System.EventHandler(this.ListView_Deactivate);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListView_FormClosing);
			this.Load += new System.EventHandler(this.ListView_Load);
			this.contextMenuStrip.ResumeLayout(false);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.filterMenuStrip.ResumeLayout(false);
			this.filterMenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView vehicleListView;
		private System.Windows.Forms.ColumnHeader columnMake;
		private System.Windows.Forms.ColumnHeader columnSpeed;
		private System.Windows.Forms.ColumnHeader columnDate;
		private System.Windows.Forms.ColumnHeader columnType;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel countToolStripStatus;
		private System.Windows.Forms.MenuStrip filterMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fastToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem slowToolStripMenuItem;
	}
}