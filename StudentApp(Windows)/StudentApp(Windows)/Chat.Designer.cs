namespace StudentApp_Windows_
{
    partial class Chat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSend = new System.Windows.Forms.Button();
            this.gdNames = new System.Windows.Forms.DataGridView();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentAppDataSet = new StudentApp_Windows_.StudentAppDataSet();
            this.studentTableTableAdapter = new StudentApp_Windows_.StudentAppDataSetTableAdapters.StudentTableTableAdapter();
            this.lstMessage = new System.Windows.Forms.ListView();
            this.txtSendMessage = new System.Windows.Forms.TextBox();
            this.txtSocketSend = new System.Windows.Forms.TextBox();
            this.txtNewSocket = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gdNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAppDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(353, 392);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(145, 46);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.StartSending);
            // 
            // gdNames
            // 
            this.gdNames.AllowUserToAddRows = false;
            this.gdNames.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdNames.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gdNames.AutoGenerateColumns = false;
            this.gdNames.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gdNames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdNames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn});
            this.gdNames.DataSource = this.studentTableBindingSource;
            this.gdNames.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gdNames.Location = new System.Drawing.Point(29, 40);
            this.gdNames.Name = "gdNames";
            this.gdNames.ReadOnly = true;
            this.gdNames.RowTemplate.Height = 24;
            this.gdNames.Size = new System.Drawing.Size(558, 62);
            this.gdNames.TabIndex = 1;
            this.gdNames.SelectionChanged += new System.EventHandler(this.lstMessage_SelectedIndexChanged);
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentTableBindingSource
            // 
            this.studentTableBindingSource.DataMember = "StudentTable";
            this.studentTableBindingSource.DataSource = this.studentAppDataSet;
            // 
            // studentAppDataSet
            // 
            this.studentAppDataSet.DataSetName = "StudentAppDataSet";
            this.studentAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableTableAdapter
            // 
            this.studentTableTableAdapter.ClearBeforeFill = true;
            // 
            // lstMessage
            // 
            this.lstMessage.Location = new System.Drawing.Point(183, 162);
            this.lstMessage.Name = "lstMessage";
            this.lstMessage.Size = new System.Drawing.Size(253, 97);
            this.lstMessage.TabIndex = 2;
            this.lstMessage.UseCompatibleStateImageBehavior = false;
            // 
            // txtSendMessage
            // 
            this.txtSendMessage.Location = new System.Drawing.Point(183, 287);
            this.txtSendMessage.Multiline = true;
            this.txtSendMessage.Name = "txtSendMessage";
            this.txtSendMessage.Size = new System.Drawing.Size(215, 38);
            this.txtSendMessage.TabIndex = 3;
            // 
            // txtSocketSend
            // 
            this.txtSocketSend.Location = new System.Drawing.Point(232, 331);
            this.txtSocketSend.Name = "txtSocketSend";
            this.txtSocketSend.Size = new System.Drawing.Size(100, 22);
            this.txtSocketSend.TabIndex = 4;
            this.txtSocketSend.Visible = false;
            // 
            // txtNewSocket
            // 
            this.txtNewSocket.Location = new System.Drawing.Point(375, 108);
            this.txtNewSocket.Name = "txtNewSocket";
            this.txtNewSocket.Size = new System.Drawing.Size(100, 22);
            this.txtNewSocket.TabIndex = 5;
            this.txtNewSocket.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(124, 392);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(142, 46);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(133, 108);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 22);
            this.txtIP.TabIndex = 7;
            this.txtIP.Visible = false;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(617, 450);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtNewSocket);
            this.Controls.Add(this.txtSocketSend);
            this.Controls.Add(this.txtSendMessage);
            this.Controls.Add(this.lstMessage);
            this.Controls.Add(this.gdNames);
            this.Controls.Add(this.btnSend);
            this.Name = "Chat";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Chat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAppDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.DataGridView gdNames;
        private StudentAppDataSet studentAppDataSet;
        private System.Windows.Forms.BindingSource studentTableBindingSource;
        private StudentAppDataSetTableAdapters.StudentTableTableAdapter studentTableTableAdapter;
        private System.Windows.Forms.ListView lstMessage;
        private System.Windows.Forms.TextBox txtSendMessage;
        private System.Windows.Forms.TextBox txtSocketSend;
        private System.Windows.Forms.TextBox txtNewSocket;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtIP;
    }
}