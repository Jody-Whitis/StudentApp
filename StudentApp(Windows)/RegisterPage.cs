using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp_Windows_
{
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            var dataPass = Encoding.ASCII.GetBytes(txtPassword.Text);
            var sha1 = new SHA1CryptoServiceProvider();
            var sha1Pass = sha1.ComputeHash(dataPass);


            string matchPass = "";
            foreach (var sha1v in sha1Pass)
            {
                matchPass += sha1v.ToString();
            }

            try
            {

                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename
=C:\Users\Jcomp\Documents\College\Senior Project\StudentApp(Windows)\StudentApp(Windows)\StudentApp.mdf;Integrated Security=True"))
                {
                    SqlCommand userMatch = new SqlCommand("INSERT INTO [StudentTable] (id,firstname,lastname,username,password) VALUES"+ 
                        "(@sid,@firstname,@lastname,@username,@password)", conn);
                    conn.Open();
                    userMatch.Parameters.AddWithValue("@username", txtUsername.Text);
                    userMatch.Parameters.AddWithValue("@sid", txtStudentID.Text);
                    userMatch.Parameters.AddWithValue("@firstname", txtFirstname.Text);
                    userMatch.Parameters.AddWithValue("@lastname", txtLastName.Text);
                    userMatch.Parameters.AddWithValue("@password", txtPassword.Text);
                    userMatch.ExecuteNonQuery();
                    conn.Close();

                }

            MessageBox.Show(txtFirstname.Text + " " + txtLastName.Text + "'s Account Created");
            LoginPage login = new LoginPage();
            login.Tag = this;
            login.Show(this);
            Hide();
            }

            catch(Exception ex)
            {
                MessageBox.Show("Username/ID Already Taken");
                Console.WriteLine(ex.ToString());
            }

            
            

        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Tag = this;

            login.Show(this);
            Hide();
        }
    }
}
