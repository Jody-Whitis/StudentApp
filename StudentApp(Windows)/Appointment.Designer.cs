namespace StudentApp_Windows_
{
    partial class Appointment
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
            this.btnMakeAppointment = new System.Windows.Forms.Button();
            this.btnViewAppointment = new System.Windows.Forms.Button();
            this.appointmentTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentAppAppointment = new StudentApp_Windows_.StudentAppAppointment();
            this.appointmentTableTableAdapter = new StudentApp_Windows_.StudentAppAppointmentTableAdapters.AppointmentTableTableAdapter();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblBuildingName = new System.Windows.Forms.Label();
            this.dtAppointment = new System.Windows.Forms.DateTimePicker();
            this.txtBuildingName = new System.Windows.Forms.TextBox();
            this.dgAppointments = new System.Windows.Forms.DataGridView();
            this.aIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentAppDataSet2 = new StudentApp_Windows_.StudentAppDataSet2();
            this.appointmentTableTableAdapter1 = new StudentApp_Windows_.StudentAppDataSet2TableAdapters.AppointmentTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAppAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAppDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMakeAppointment
            // 
            this.btnMakeAppointment.Location = new System.Drawing.Point(210, 230);
            this.btnMakeAppointment.Name = "btnMakeAppointment";
            this.btnMakeAppointment.Size = new System.Drawing.Size(75, 23);
            this.btnMakeAppointment.TabIndex = 0;
            this.btnMakeAppointment.Text = "Make Appointment";
            this.btnMakeAppointment.UseVisualStyleBackColor = true;
            this.btnMakeAppointment.Click += new System.EventHandler(this.btnMakeAppointment_Click);
            // 
            // btnViewAppointment
            // 
            this.btnViewAppointment.Location = new System.Drawing.Point(410, 230);
            this.btnViewAppointment.Name = "btnViewAppointment";
            this.btnViewAppointment.Size = new System.Drawing.Size(75, 23);
            this.btnViewAppointment.TabIndex = 1;
            this.btnViewAppointment.Text = "View Appointment";
            this.btnViewAppointment.UseVisualStyleBackColor = true;
            this.btnViewAppointment.Click += new System.EventHandler(this.btnViewAppointment_Click);
            // 
            // appointmentTableBindingSource
            // 
            this.appointmentTableBindingSource.DataMember = "AppointmentTable";
            this.appointmentTableBindingSource.DataSource = this.studentAppAppointment;
            // 
            // studentAppAppointment
            // 
            this.studentAppAppointment.DataSetName = "StudentAppAppointment";
            this.studentAppAppointment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentTableTableAdapter
            // 
            this.appointmentTableTableAdapter.ClearBeforeFill = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(304, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Magneto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(59, 29);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(54, 21);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Data";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Magneto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(119, 29);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(55, 21);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Time";
            // 
            // lblBuildingName
            // 
            this.lblBuildingName.AutoSize = true;
            this.lblBuildingName.Font = new System.Drawing.Font("Magneto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuildingName.ForeColor = System.Drawing.Color.White;
            this.lblBuildingName.Location = new System.Drawing.Point(77, 114);
            this.lblBuildingName.Name = "lblBuildingName";
            this.lblBuildingName.Size = new System.Drawing.Size(86, 21);
            this.lblBuildingName.TabIndex = 7;
            this.lblBuildingName.Text = "Building";
            // 
            // dtAppointment
            // 
            this.dtAppointment.Location = new System.Drawing.Point(193, 29);
            this.dtAppointment.MinDate = new System.DateTime(2018, 4, 27, 0, 0, 0, 0);
            this.dtAppointment.Name = "dtAppointment";
            this.dtAppointment.Size = new System.Drawing.Size(246, 22);
            this.dtAppointment.TabIndex = 8;
            // 
            // txtBuildingName
            // 
            this.txtBuildingName.Location = new System.Drawing.Point(193, 114);
            this.txtBuildingName.Name = "txtBuildingName";
            this.txtBuildingName.Size = new System.Drawing.Size(246, 22);
            this.txtBuildingName.TabIndex = 9;
            // 
            // dgAppointments
            // 
            this.dgAppointments.AutoGenerateColumns = false;
            this.dgAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aIdDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.bidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dgAppointments.DataSource = this.appointmentTableBindingSource1;
            this.dgAppointments.Location = new System.Drawing.Point(123, 259);
            this.dgAppointments.Name = "dgAppointments";
            this.dgAppointments.RowTemplate.Height = 24;
            this.dgAppointments.Size = new System.Drawing.Size(465, 150);
            this.dgAppointments.TabIndex = 10;
            // 
            // aIdDataGridViewTextBoxColumn
            // 
            this.aIdDataGridViewTextBoxColumn.DataPropertyName = "aId";
            this.aIdDataGridViewTextBoxColumn.HeaderText = "aId";
            this.aIdDataGridViewTextBoxColumn.Name = "aIdDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // bidDataGridViewTextBoxColumn
            // 
            this.bidDataGridViewTextBoxColumn.DataPropertyName = "bid";
            this.bidDataGridViewTextBoxColumn.HeaderText = "bid";
            this.bidDataGridViewTextBoxColumn.Name = "bidDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // appointmentTableBindingSource1
            // 
            this.appointmentTableBindingSource1.DataMember = "AppointmentTable";
            this.appointmentTableBindingSource1.DataSource = this.studentAppDataSet2;
            // 
            // studentAppDataSet2
            // 
            this.studentAppDataSet2.DataSetName = "StudentAppDataSet2";
            this.studentAppDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentTableTableAdapter1
            // 
            this.appointmentTableTableAdapter1.ClearBeforeFill = true;
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.dgAppointments);
            this.Controls.Add(this.txtBuildingName);
            this.Controls.Add(this.dtAppointment);
            this.Controls.Add(this.lblBuildingName);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnViewAppointment);
            this.Controls.Add(this.btnMakeAppointment);
            this.Name = "Appointment";
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.Appointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAppAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAppDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMakeAppointment;
        private System.Windows.Forms.Button btnViewAppointment;
        private StudentAppAppointment studentAppAppointment;
        private System.Windows.Forms.BindingSource appointmentTableBindingSource;
        private StudentAppAppointmentTableAdapters.AppointmentTableTableAdapter appointmentTableTableAdapter;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblBuildingName;
        private System.Windows.Forms.DateTimePicker dtAppointment;
        private System.Windows.Forms.TextBox txtBuildingName;
        private System.Windows.Forms.DataGridView dgAppointments;
        private StudentAppDataSet2 studentAppDataSet2;
        private System.Windows.Forms.BindingSource appointmentTableBindingSource1;
        private StudentAppDataSet2TableAdapters.AppointmentTableTableAdapter appointmentTableTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}