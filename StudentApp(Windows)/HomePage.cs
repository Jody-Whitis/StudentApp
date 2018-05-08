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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();


        }

        List<string> dateList;
        List<string> timeList = new List<string>();

        private string Remainder(List<string> date, List<string> timeLi)
        {
            string today="";
            string rem = "";
            var day = DateTime.Now;
            today = day.ToString("M/d/yyyy");
            Console.WriteLine(today);
            foreach(string dt in date)
            {
                Console.Write(dt);
            }
      
            if (date.Contains(today))
            {
                rem = "Appointment Today!";
                lblRemainder.Text = rem;

                for (int i =0; i<date.Count; i++)
            {
                Console.WriteLine(date[i]);
                if(String.Compare(date[i],today)== 0)
                {

                    rem = "Appointment Today at: " + timeLi[i];
                }

            }
            }
            
            return rem;
        }

        private List<string> getAppointmentTimes()
        {
            List<string> date = new List<string>();

            try
            {

                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
C:\Users\Jcomp\Documents\College\Senior Project\StudentApp(Windows)\StudentApp(Windows)\StudentApp.mdf;Integrated Security=True"))
                {

                    SqlCommand userMatch = new SqlCommand("SELECT date,time,name FROM [AppointmentTable] WHERE sid=@sid ", conn);
                    conn.Open();

                    userMatch.Parameters.AddWithValue("@sid", CurrentUser.Sid);
                    SqlDataReader reader = userMatch.ExecuteReader();
                    
                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {
                            date.Add(reader["date"].ToString().TrimEnd(' '));
                            timeList.Add(reader["time"].ToString().TrimEnd(' '));

                        }

                      
                        conn.Close();

                    }
                }
            }

            catch (Exception ex)
            {

                Console.WriteLine("***" + ex.ToString() + "***");

            }
            return date;

            
        }



        private void LoadInfomation()
        {

            Console.WriteLine("WELCOME ID: "+ CurrentUser.Sid + "|" + "'" + CurrentUser.Fname + "'");

        }
        private void btnAppointments_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            appointment.Tag =  this;
            appointment.Show(this);
            Hide();
            LoadInfomation();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Maps maps = new Maps();
            maps.Tag = this;
            maps.Show(this);
            Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Chat chat = new Chat();
            chat.Tag = this;
            chat.Show(this);
            Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CoursePage course = new CoursePage();
            course.Tag = this;
            course.Show(this);
            Hide();
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Tag = this;
            login.Show(this);
            Hide();
            Application.Exit();
            
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            LoadInfomation();
            dateList = getAppointmentTimes();
            Remainder(dateList,timeList);
        }
    }
}
