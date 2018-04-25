using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        }
    }
}
