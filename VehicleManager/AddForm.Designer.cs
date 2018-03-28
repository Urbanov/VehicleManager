namespace VehicleManager
{
	partial class AddForm
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
			this.makeLabel = new System.Windows.Forms.Label();
			this.speedLabel = new System.Windows.Forms.Label();
			this.dateLabel = new System.Windows.Forms.Label();
			this.typeLabel = new System.Windows.Forms.Label();
			this.makeTextBox = new System.Windows.Forms.TextBox();
			this.speedTextBox = new System.Windows.Forms.TextBox();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.cancelButton = new System.Windows.Forms.Button();
			this.okButton = new System.Windows.Forms.Button();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.typeTextBox = new System.Windows.Forms.TextBox();
			this.typeControl = new VehicleManager.TypeControl();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// makeLabel
			// 
			this.makeLabel.AutoSize = true;
			this.makeLabel.Location = new System.Drawing.Point(12, 21);
			this.makeLabel.Name = "makeLabel";
			this.makeLabel.Size = new System.Drawing.Size(34, 13);
			this.makeLabel.TabIndex = 0;
			this.makeLabel.Text = "Make";
			// 
			// speedLabel
			// 
			this.speedLabel.AutoSize = true;
			this.speedLabel.Location = new System.Drawing.Point(12, 51);
			this.speedLabel.Name = "speedLabel";
			this.speedLabel.Size = new System.Drawing.Size(60, 13);
			this.speedLabel.TabIndex = 1;
			this.speedLabel.Text = "Top Speed";
			// 
			// dateLabel
			// 
			this.dateLabel.AutoSize = true;
			this.dateLabel.Location = new System.Drawing.Point(12, 81);
			this.dateLabel.Name = "dateLabel";
			this.dateLabel.Size = new System.Drawing.Size(30, 13);
			this.dateLabel.TabIndex = 2;
			this.dateLabel.Text = "Date";
			// 
			// typeLabel
			// 
			this.typeLabel.AutoSize = true;
			this.typeLabel.Location = new System.Drawing.Point(12, 111);
			this.typeLabel.Name = "typeLabel";
			this.typeLabel.Size = new System.Drawing.Size(31, 13);
			this.typeLabel.TabIndex = 3;
			this.typeLabel.Text = "Type";
			// 
			// makeTextBox
			// 
			this.makeTextBox.Location = new System.Drawing.Point(89, 18);
			this.makeTextBox.Name = "makeTextBox";
			this.makeTextBox.Size = new System.Drawing.Size(200, 20);
			this.makeTextBox.TabIndex = 4;
			this.makeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.makeTextBox_Validating);
			this.makeTextBox.Validated += new System.EventHandler(this.makeTextBox_Validated);
			// 
			// speedTextBox
			// 
			this.speedTextBox.Location = new System.Drawing.Point(89, 48);
			this.speedTextBox.Name = "speedTextBox";
			this.speedTextBox.Size = new System.Drawing.Size(200, 20);
			this.speedTextBox.TabIndex = 5;
			this.speedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.speedTextBox_Validating);
			this.speedTextBox.Validated += new System.EventHandler(this.speedTextBox_Validated);
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.Location = new System.Drawing.Point(89, 75);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker.TabIndex = 6;
			this.dateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePicker_Validating);
			this.dateTimePicker.Validated += new System.EventHandler(this.dateTimePicker_Validated);
			// 
			// cancelButton
			// 
			this.cancelButton.CausesValidation = false;
			this.cancelButton.Location = new System.Drawing.Point(162, 167);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 7;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// okButton
			// 
			this.okButton.Location = new System.Drawing.Point(62, 167);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 8;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// typeTextBox
			// 
			this.typeTextBox.CausesValidation = false;
			this.typeTextBox.Location = new System.Drawing.Point(189, 111);
			this.typeTextBox.Name = "typeTextBox";
			this.typeTextBox.ReadOnly = true;
			this.typeTextBox.Size = new System.Drawing.Size(100, 20);
			this.typeTextBox.TabIndex = 10;
			// 
			// typeControl
			// 
			this.typeControl.CausesValidation = false;
			this.typeControl.Location = new System.Drawing.Point(89, 81);
			this.typeControl.Name = "typeControl";
			this.typeControl.Size = new System.Drawing.Size(80, 80);
			this.typeControl.TabIndex = 9;
			this.typeControl.Type = VehicleManager.Vehicle.type.Truck;
			this.typeControl.TypeChanged += new System.EventHandler(this.typeControl_TypeChanged);
			// 
			// AddForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(314, 202);
			this.Controls.Add(this.typeTextBox);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.dateTimePicker);
			this.Controls.Add(this.speedTextBox);
			this.Controls.Add(this.makeTextBox);
			this.Controls.Add(this.typeLabel);
			this.Controls.Add(this.dateLabel);
			this.Controls.Add(this.speedLabel);
			this.Controls.Add(this.makeLabel);
			this.Controls.Add(this.typeControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddForm";
			this.Text = "Enter vehicle data";
			this.Load += new System.EventHandler(this.AddForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label makeLabel;
		private System.Windows.Forms.Label speedLabel;
		private System.Windows.Forms.Label dateLabel;
		private System.Windows.Forms.Label typeLabel;
		private System.Windows.Forms.TextBox makeTextBox;
		private System.Windows.Forms.TextBox speedTextBox;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.TextBox typeTextBox;
		private TypeControl typeControl;
	}
}