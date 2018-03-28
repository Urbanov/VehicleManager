using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleManager
{
	public partial class TypeControl : UserControl
	{
		private PictureBox pictureBox;
		private static Image[] imageList = { Resources.car, Resources.truck, Resources.bike };
		private Vehicle.type currentType;

		[Editor(typeof(TypeEditor), typeof(System.Drawing.Design.UITypeEditor))]
		[Category("Default Type")]
		[Description("Choose default type (custom)")]
		[Browsable(true)]
		public Vehicle.type Type
		{
			get
			{
				return currentType;
			}
			set
			{
				currentType = value;
				pictureBox.Image = imageList[(int)currentType];
				OnTypeChanged(EventArgs.Empty);
			}
		}

		public TypeControl()
		{
			InitializeComponent();
		}

		public delegate void TypeChangedEventHandler(object sender, EventArgs e);

		[Category("Action")]
		[Description("Fires when the type is changed (custom)")]
		public event EventHandler TypeChanged;

		protected virtual void OnTypeChanged(EventArgs e)
		{
			TypeChanged?.Invoke(this, e);
		}

		private void InitializeComponent()
		{
			this.pictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox
			// 
			this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox.Location = new System.Drawing.Point(0, 0);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(80, 80);
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
			// 
			// TypeControl
			// 
			this.Controls.Add(this.pictureBox);
			this.Name = "TypeControl";
			this.Size = new System.Drawing.Size(80, 80);
			this.Click += new System.EventHandler(this.TypeControl_Click);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		private void TypeControl_Click(object sender, EventArgs e)
		{
			Type = (Vehicle.type)(((int)currentType + 1) % 3);
		}

		public override string ToString()
		{
			return currentType.ToString();
		}

		private void pictureBox_Click(object sender, EventArgs e)
		{
			TypeControl_Click(sender, e);
		}
	}
}
