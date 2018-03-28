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
	public partial class ListView : Form, ViewInterface
	{
		private String defaultBarText;

		public ListView()
		{
			defaultBarText = "Vehicles";
			InitializeComponent();
		}

		private void ListView_Load(object sender, EventArgs e)
		{
			Text = defaultBarText;
			allToolStripMenuItem.Checked = true;
			Refresh(((MainForm)MdiParent).Vehicles);
		}

		private void DisableAllFilters()
		{
			slowToolStripMenuItem.Checked = false;
			fastToolStripMenuItem.Checked = false;
			allToolStripMenuItem.Checked = false;
		}

		private void filterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!((ToolStripMenuItem)sender).Checked)
			{
				DisableAllFilters();
				((ToolStripMenuItem)sender).Checked = true;
				Refresh(((MainForm)MdiParent).Vehicles);
				Text = defaultBarText + (
					((ToolStripMenuItem)sender) == allToolStripMenuItem
						? ""
						: " (" + ((ToolStripMenuItem)sender).Text + ")"
				);
			}
		}

		private void ListView_Activated(object sender, EventArgs e)
		{
			ToolStripManager.Merge(statusStrip, ((MainForm)MdiParent).MDIStatusStrip);
		}

		private void ListView_Deactivate(object sender, EventArgs e)
		{
			ToolStripManager.RevertMerge(((MainForm)MdiParent).MDIStatusStrip, statusStrip);
		}

		private void ListView_FormClosing(object sender, FormClosingEventArgs e)
		{
			((MainForm)MdiParent).InnerFormClosing(sender, e);
		}

		private void addToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddForm form = new AddForm(null);
			if (form.ShowDialog() == DialogResult.OK) {
				Vehicle vehicle = new Vehicle(form.VehicleMake, form.VehicleSpeed, form.VehicleDate, form.VehicleType);
				((MainForm)MdiParent).AddVehicle(vehicle);
			}
		}

		private void editToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Vehicle vehicle = (Vehicle)vehicleListView.SelectedItems[0].Tag;
			AddForm form = new AddForm(vehicle);
			if (form.ShowDialog() == DialogResult.OK) {
				vehicle.Make = form.VehicleMake;
				vehicle.Speed = form.VehicleSpeed;
				vehicle.Date = form.VehicleDate;
				vehicle.Type = form.VehicleType;
				((MainForm)MdiParent).EditVehicle(vehicle);
			}
		}

		private void removeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Vehicle vehicle = (Vehicle)vehicleListView.SelectedItems[0].Tag;
			((MainForm)MdiParent).RemoveVehicle(vehicle);
		}

		private ListViewItem FindItemByTag(Vehicle vehicle)
		{
			foreach (ListViewItem item in vehicleListView.Items) {
				if (item.Tag == vehicle) {
					return item;
				}
			}
			return null;
		}

		private void UpdateItem(ListViewItem item)
		{
			Vehicle vehicle = (Vehicle)item.Tag;
			while (item.SubItems.Count < 4) {
				item.SubItems.Add(new ListViewItem.ListViewSubItem());
			}
			item.SubItems[0].Text = vehicle.Make;
			item.SubItems[1].Text = vehicle.Speed.ToString();
			item.SubItems[2].Text = vehicle.Date.ToShortDateString();
			item.SubItems[3].Text = vehicle.Type.ToString();
		}

		private void AddNewItem(Vehicle vehicle)
		{
			ListViewItem item = new ListViewItem();
			item.Tag = vehicle;
			UpdateItem(item);
			vehicleListView.Items.Add(item);
		}

		public void Add(Vehicle vehicle)
		{
			if (CheckFilter(vehicle)) {
				AddNewItem(vehicle);
				countToolStripStatus.Text = vehicleListView.Items.Count.ToString();
			}
		}

		public void Remove(Vehicle vehicle)
		{
			ListViewItem item = FindItemByTag(vehicle);
			if (item != null) {
				vehicleListView.Items.Remove(item);
				countToolStripStatus.Text = vehicleListView.Items.Count.ToString();
			}
		}

		public void Edit(Vehicle vehicle)
		{
			ListViewItem item = FindItemByTag(vehicle);
			if (CheckFilter(vehicle)) {
				if (item == null) {
					AddNewItem(vehicle);
				}
				else {
					UpdateItem(item);
				}
			}
			else if (item != null) {
				vehicleListView.Items.Remove(item);
			}
			countToolStripStatus.Text = vehicleListView.Items.Count.ToString();
		}

		public void Refresh(List<Vehicle> vehicles)
		{
			vehicleListView.Items.Clear();
			foreach (Vehicle vehicle in vehicles) {
				if (CheckFilter(vehicle)) {
					AddNewItem(vehicle);
				}
			}
			countToolStripStatus.Text = vehicleListView.Items.Count.ToString();
		}

		private bool CheckFilter(Vehicle vehicle)
		{
			if (allToolStripMenuItem.Checked) {
				return true;
			}
			if (fastToolStripMenuItem.Checked && vehicle.Speed >= 100) {
				return true;
			}
			if (slowToolStripMenuItem.Checked && vehicle.Speed < 100) {
				return true;
			}
			return false;
		}

		private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
		{
			if (vehicleListView.SelectedItems.Count == 1) {
				removeToolStripMenuItem.Enabled = true;
				editToolStripMenuItem.Enabled = true;
			}
			else {
				removeToolStripMenuItem.Enabled = false;
				editToolStripMenuItem.Enabled = false;
			}
		}
	}
}
