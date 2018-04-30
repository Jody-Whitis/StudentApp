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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        public bool validUser = false;
        public string firstName;
        public string lastName;
        public int studentID;
        public string username;
        public string password;
        List<string> userDatabase;
        private void ValidateUser(object sender, EventArgs e)
        {


           using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename
=C:\Users\Jcomp\Documents\College\Senior Project\StudentApp(Windows)\StudentApp(Windows)\StudentApp.mdf;Integrated Security=True"))
            {
                SqlCommand userMatch = new SqlCommand("Select * from [StudentTable] where username=@username and password=@password", conn);
                conn.Open();
                userMatch.Parameters.AddWithValue("@username", txtUsername.Text);
                userMatch.Parameters.AddWithValue("@password", txtPassword.Text);

                SqlDataReader reader = userMatch.ExecuteReader();
                userDatabase = new List<string>();

                

               


                if (reader.HasRows)
                {
                    validUser = true;
                    while (reader.Read())
                {
                    studentID = (int)reader["id"];
                    username = reader["username"].ToString();
                    password = reader["password"].ToString();
                    firstName = reader["firstname"].ToString();
                    lastName = reader["lastname"].ToString();
                }

                    HomePage home = new HomePage();
                    home.Tag = this;
                    home.Show(this);
                    Hide();
                    CurrentUser.Fname= firstName;
                    CurrentUser.Sid = studentID;
                    CurrentUser.Lname = lastName;

                }

                else
                {
                    MessageBox.Show("Invalid username/password");
                }

                conn.Close();

            }


  
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            
         
            HomePage home = new HomePage();
            home.Tag = this;
            home.Show(this);
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterPage register = new RegisterPage();
            register.Tag = this;
            register.Show(this);
            Hide();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
       
    }
}
