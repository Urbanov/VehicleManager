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
	public partial class AddForm : Form
	{
		private Vehicle vehicle;
		private static String errorText = "Incorrect input data";

		public AddForm(Vehicle vehicle)
		{
			InitializeComponent();
			this.vehicle = vehicle;
		}

		public String VehicleMake
		{
			get { return makeTextBox.Text; }
		}

		public int VehicleSpeed
		{
			get { return int.Parse(speedTextBox.Text); }
		}

		public DateTime VehicleDate
		{
			get { return dateTimePicker.Value; }
		}

		public Vehicle.type VehicleType
		{
			get { return typeControl.Type; }
		}

		private void AddForm_Load(object sender, EventArgs e)
		{
			if (vehicle != null) {
				makeTextBox.Text = vehicle.Make;
				speedTextBox.Text = vehicle.Speed.ToString();
				dateTimePicker.Value = vehicle.Date;
				typeControl.Type = vehicle.Type;
			}
			else {
				typeTextBox.Text = typeControl.ToString();
			}
		}

		private void makeTextBox_Validating(object sender, CancelEventArgs e)
		{
			if (makeTextBox.Text.Length == 0) {
				e.Cancel = true;
				errorProvider.SetError(makeTextBox, errorText);
			}
		}

		private void speedTextBox_Validating(object sender, CancelEventArgs e)
		{
			try {
				int.Parse(speedTextBox.Text);
			}
			catch (Exception exception) {
				e.Cancel = true;
				errorProvider.SetError(speedTextBox, errorText);
			}
		}

		private void dateTimePicker_Validating(object sender, CancelEventArgs e)
		{
			if (dateTimePicker.Value > DateTime.Now) {
				e.Cancel = true;
				errorProvider.SetError(dateTimePicker, errorText);
			}
		}

		private void makeTextBox_Validated(object sender, EventArgs e)
		{
			errorProvider.SetError(makeTextBox, "");
		}

		private void speedTextBox_Validated(object sender, EventArgs e)
		{
			errorProvider.SetError(speedTextBox, "");
		}

		private void dateTimePicker_Validated(object sender, EventArgs e)
		{
			errorProvider.SetError(dateTimePicker, "");
		}	

		private void cancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			if (ValidateChildren()) {
				DialogResult = DialogResult.OK;
			}
		}

		private void typeControl_TypeChanged(object sender, EventArgs e)
		{
			typeTextBox.Text = ((TypeControl)sender).ToString();
		}
	}
}
