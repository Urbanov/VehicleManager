using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleManager
{
	public partial class MainForm : Form
	{
		private List<Vehicle> vehicles;
		public List<Vehicle> Vehicles
		{
			get
			{
				return vehicles;
			}
		}

		public MainForm()
		{
			vehicles = new List<Vehicle>();
			InitializeComponent();
		}

		public void InnerFormClosing(object sender, FormClosingEventArgs e)
		{
			if (MdiChildren.Length == 1 && e.CloseReason != CloseReason.MdiFormClosing) {
				e.Cancel = true;
			}
		}

		private void OpenInnerForm()
		{
			ListView view = new ListView();
			view.MdiParent = this;
			view.Show();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			OpenInnerForm();
		}
		
		private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenInnerForm();
		}

		public void AddVehicle(Vehicle vehicle)
		{
			vehicles.Add(vehicle);
			foreach (ViewInterface view in MdiChildren) {
				view.Add(vehicle);
			}
		}

		public void EditVehicle(Vehicle vehicle)
		{
			foreach (ViewInterface view in MdiChildren) {
				view.Edit(vehicle);
			}
		}

		public void RemoveVehicle(Vehicle vehicle)
		{
			vehicles.Remove(vehicle);
			foreach (ViewInterface view in MdiChildren) {
				view.Remove(vehicle);
			}
		}
	}
}
