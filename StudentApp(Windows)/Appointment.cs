using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp_Windows_
{
    public partial class Appointment : Form
    {

        private string fullDate;
        private string time;
        private int aid;

        public Appointment()
        {
            InitializeComponent();
        }


        private void Appointment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentAppDataSet2.AppointmentTable' table. You can move, or remove it, as needed.
            this.appointmentTableTableAdapter1.Fill(this.studentAppDataSet2.AppointmentTable);

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Tag = this;

            home.Show(this);
            Hide();

        }

        private void btnViewAppointment_Click(object sender, EventArgs e)
        {
 
            lblData.Visible = true;
            lblTime.Visible = true;
            lblBuildingName.Visible = true;
            btnMakeAppointment.Visible = true;
  
            

        }

        private void btnMakeAppointment_Click(object sender, EventArgs e)
        {
 
            


            try
            {

                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
C:\Users\Jcomp\Documents\College\Senior Project\StudentApp(Windows)\StudentApp(Windows)\StudentApp.mdf;Integrated Security=True"))
                {

                     


                    SqlCommand userMatch = new SqlCommand("INSERT INTO [AppointmentTable] (name,sid,date,time) VALUES (@name,@sid,@date,@time)", conn);
                    conn.Open();
                    fullDate = (dtAppointment.Value.Month + "/" + dtAppointment.Value.Day + "/" + dtAppointment.Value.Year).ToString();
                    time = dtAppointment.Value.TimeOfDay.ToString();


                    userMatch.Parameters.AddWithValue("@name", txtBuildingName.Text);
                    userMatch.Parameters.AddWithValue("@sid", CurrentUser.Sid);
                   // userMatch.Parameters.AddWithValue("@aid", 4);
                    userMatch.Parameters.AddWithValue("@date", fullDate);
                    userMatch.Parameters.AddWithValue("@time", time);
                    userMatch.ExecuteNonQuery();


                    MessageBox.Show(CurrentUser.Fname + " " + CurrentUser.Lname + "SAVED at [" + fullDate + "]");

                    conn.Close();



                }
            }


            catch (Exception ex)
            {


                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename
=C:\Users\Jcomp\Documents\College\Senior Project\StudentApp(Windows)\StudentApp(Windows)\StudentApp.mdf;Integrated Security=True"))
                {
                    SqlCommand userMatch = new SqlCommand("UPDATE [AppointmentTable] SET name=@name, sid=@sid, aid=@aid,date=@date,time=@time WHERE aId = @aid", conn);
                    conn.Open();
                    fullDate = (dtAppointment.Value.Month + "/"+ dtAppointment.Value.Day + "/" + dtAppointment.Value.Year).ToString();
                    time = dtAppointment.Value.TimeOfDay.ToString();

                    userMatch.Parameters.AddWithValue("@name", txtBuildingName.Text);
                    userMatch.Parameters.AddWithValue("@sid", CurrentUser.Sid);
                    userMatch.Parameters.AddWithValue("@aid", 4);
                    userMatch.Parameters.AddWithValue("@date", fullDate );
                    userMatch.Parameters.AddWithValue("@time", time);
                    userMatch.ExecuteNonQuery();

                    MessageBox.Show(CurrentUser.Fname + " " + CurrentUser.Lname + "SAVED at [" + fullDate + "]");

                    conn.Close();

                }

             }





        }
    }
}
