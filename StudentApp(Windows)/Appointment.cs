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
        private double hour;
        private double min;
        private double sec;
        private string fullTime;
        private string amPm = "am";
        public Appointment()
        {
            InitializeComponent();
            txtBuildingName.Text = CurrentUser.Place;
            fillAppointmentList();
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
            #region 12hr clock
            hour = dtTime.Value.Hour;
            if(hour > 12 && hour != 12)
            {
                hour %= 12;
                amPm = "PM";
            }
           
            min = dtTime.Value.Minute;
            sec = dtTime.Value.Second;
            sec = Math.Floor(sec * 100) / 100;
            #endregion
            fullTime = hour.ToString() + ":" + min.ToString() + " "  + amPm;

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
                    userMatch.Parameters.AddWithValue("@date", fullDate);
                    userMatch.Parameters.AddWithValue("@time", fullTime);
                    userMatch.ExecuteNonQuery();


                    MessageBox.Show(CurrentUser.Fname + "" + CurrentUser.Lname + "SAVED at [" + fullTime + "]");

                    conn.Close();
                    dgAppointments.Update();
                    dgAppointments.Refresh();

                }
            }


            catch (Exception ex)
            {

                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename
=C:\Users\Jcomp\Documents\College\Senior Project\StudentApp(Windows)\StudentApp(Windows)\StudentApp.mdf;Integrated Security=True"))
                {
                    SqlCommand userMatch = new SqlCommand("UPDATE [AppointmentTable] SET name=@name, sid=@sid, aid=@aid,date=@date,time=@time WHERE aId = @aid", conn);
                    conn.Open();
                    fullDate = (dtAppointment.Value.Month + "/" + dtAppointment.Value.Day + "/" + dtAppointment.Value.Year).ToString();
                    time = dtAppointment.Value.TimeOfDay.ToString();

                    userMatch.Parameters.AddWithValue("@name", txtBuildingName.Text);
                    userMatch.Parameters.AddWithValue("@sid", CurrentUser.Sid);
                    userMatch.Parameters.AddWithValue("@aid", 2);
                    userMatch.Parameters.AddWithValue("@date", fullDate);
                    userMatch.Parameters.AddWithValue("@time", fullTime);
                    userMatch.ExecuteNonQuery();

                    MessageBox.Show(CurrentUser.Fname + " " + CurrentUser.Lname + "SAVED at [" + fullTime + "]");

                    conn.Close();

                }
             }




        }
   
        private void fillAppointmentList()
        {
            List<string> appointmentList = new List<string>();
            try
            {

                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
C:\Users\Jcomp\Documents\College\Senior Project\StudentApp(Windows)\StudentApp(Windows)\StudentApp.mdf;Integrated Security=True"))
                {

//"SELECT * FROM [AppointmentTable] WHERE sid=@sid"
                    

                    SqlCommand userMatch = new SqlCommand("SELECT s.id,s.firstname,s.lastname,a.date,a.time,a.name FROM StudentTable s INNER JOIN AppointmentTable a ON " +
                    "a.sid = s.id WHERE s.id = @sid AND time=a.time AND date=a.date AND name=a.name", conn);
                    conn.Open();

                    userMatch.Parameters.AddWithValue("@sid", CurrentUser.Sid);
                    SqlDataReader reader = userMatch.ExecuteReader();



                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {
                            appointmentList.Add(
                                reader["date"].ToString() + reader["time"].ToString()
                                + reader["name"].ToString() + reader["firstname"].ToString()
                                );

                        }

                        foreach (string apt in appointmentList)
                        {

                            lstAppointments.Items.Add(apt);
                        }

                         conn.Close();
                 
                    }
                }
            }

            catch (Exception ex)
            {

                Console.WriteLine("***" + ex.ToString() + "***");

            }




        }



    }
}
