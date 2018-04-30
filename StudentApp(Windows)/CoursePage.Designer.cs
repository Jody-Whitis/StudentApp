namespace StudentApp_Windows_
{
    partial class CoursePage
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
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.txtBid = new System.Windows.Forms.TextBox();
            this.txtRoomnumber = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblCourseSection = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.lblBuilding = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(178, 61);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(154, 22);
            this.txtCourseID.TabIndex = 0;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(178, 102);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(154, 22);
            this.txtCourseName.TabIndex = 1;
            // 
            // txtSection
            // 
            this.txtSection.Location = new System.Drawing.Point(178, 143);
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(154, 22);
            this.txtSection.TabIndex = 2;
            // 
            // txtBid
            // 
            this.txtBid.Location = new System.Drawing.Point(178, 185);
            this.txtBid.Name = "txtBid";
            this.txtBid.Size = new System.Drawing.Size(154, 22);
            this.txtBid.TabIndex = 3;
            // 
            // txtRoomnumber
            // 
            this.txtRoomnumber.Location = new System.Drawing.Point(178, 232);
            this.txtRoomnumber.Name = "txtRoomnumber";
            this.txtRoomnumber.Size = new System.Drawing.Size(154, 22);
            this.txtRoomnumber.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(317, 404);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 34);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(68, 404);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 34);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Magneto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.ForeColor = System.Drawing.Color.White;
            this.lblCourseName.Location = new System.Drawing.Point(58, 62);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(101, 21);
            this.lblCourseName.TabIndex = 7;
            this.lblCourseName.Text = "Course iD";
            // 
            // lblCourseSection
            // 
            this.lblCourseSection.AutoSize = true;
            this.lblCourseSection.Font = new System.Drawing.Font("Magneto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseSection.ForeColor = System.Drawing.Color.White;
            this.lblCourseSection.Location = new System.Drawing.Point(26, 102);
            this.lblCourseSection.Name = "lblCourseSection";
            this.lblCourseSection.Size = new System.Drawing.Size(133, 21);
            this.lblCourseSection.TabIndex = 8;
            this.lblCourseSection.Text = "Course Name";
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Magneto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.ForeColor = System.Drawing.Color.White;
            this.lblSection.Location = new System.Drawing.Point(9, 144);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(150, 21);
            this.lblSection.TabIndex = 9;
            this.lblSection.Text = "Course Section";
            // 
            // lblBuilding
            // 
            this.lblBuilding.AutoSize = true;
            this.lblBuilding.Font = new System.Drawing.Font("Magneto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuilding.ForeColor = System.Drawing.Color.White;
            this.lblBuilding.Location = new System.Drawing.Point(58, 186);
            this.lblBuilding.Name = "lblBuilding";
            this.lblBuilding.Size = new System.Drawing.Size(86, 21);
            this.lblBuilding.TabIndex = 10;
            this.lblBuilding.Text = "Building";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Magneto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.ForeColor = System.Drawing.Color.White;
            this.lblRoomNumber.Location = new System.Drawing.Point(26, 232);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(140, 21);
            this.lblRoomNumber.TabIndex = 11;
            this.lblRoomNumber.Text = "Room Number";
            // 
            // CoursePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(508, 450);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.lblBuilding);
            this.Controls.Add(this.lblSection);
            this.Controls.Add(this.lblCourseSection);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRoomnumber);
            this.Controls.Add(this.txtBid);
            this.Controls.Add(this.txtSection);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtCourseID);
            this.Name = "CoursePage";
            this.Text = "CoursePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.TextBox txtBid;
        private System.Windows.Forms.TextBox txtRoomnumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCourseSection;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label lblBuilding;
        private System.Windows.Forms.Label lblRoomNumber;
    }
}