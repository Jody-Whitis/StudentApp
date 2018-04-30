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
    public partial class CoursePage : Form
    {
        public CoursePage()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Tag = this;

            home.Show(this);
            Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename
=C:\Users\Jcomp\Documents\College\Senior Project\StudentApp(Windows)\StudentApp(Windows)\StudentApp.mdf;Integrated Security=True"))
                {
                    SqlCommand userMatch = new SqlCommand("INSERT INTO [CourseTable] (cId,coursename,section,bid,roomnumber,sid) VALUES (@cId,@coursename,@section,@bid,@roomnumber,@sid)", conn);
                    conn.Open();
                    userMatch.Parameters.AddWithValue("@cId", txtCourseID.Text);
                    userMatch.Parameters.AddWithValue("@coursename", txtCourseName.Text);
                    userMatch.Parameters.AddWithValue("@section", Convert.ToInt32(txtSection.Text));
                    userMatch.Parameters.AddWithValue("@bid", Convert.ToInt32(txtBid.Text));
                    userMatch.Parameters.AddWithValue("@roomnumber", Convert.ToInt32(txtRoomnumber.Text));
                    userMatch.Parameters.AddWithValue("@sid", CurrentUser.Sid);
                    userMatch.ExecuteNonQuery();

                    conn.Close();

                }

            }
            catch (Exception ex)
            {


                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename
=C:\Users\Jcomp\Documents\College\Senior Project\StudentApp(Windows)\StudentApp(Windows)\StudentApp.mdf;Integrated Security=True"))
                {
                    SqlCommand userMatch = new SqlCommand("UPDATE [CourseTable] SET coursename=@coursename, section=@section,bid=@bid,roomnumber=@roomnumber", conn);
                    conn.Open();
                    userMatch.Parameters.AddWithValue("@coursename", txtCourseName.Text);
                    userMatch.Parameters.AddWithValue("@section", Convert.ToInt32(txtSection.Text));
                    userMatch.Parameters.AddWithValue("@bid", Convert.ToInt32(txtBid.Text));
                    userMatch.Parameters.AddWithValue("@roomnumber", Convert.ToInt32(txtRoomnumber.Text));
                    userMatch.ExecuteNonQuery();
                    conn.Close();

                }
                Console.WriteLine("UPDATED Course for " + CurrentUser.Fname);
            }
        }
    }
}
