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
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Tag = this;
            login.Show(this);
            Hide();

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
