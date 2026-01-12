using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuzzyKits
{
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        private void BtHome_Click(object sender, EventArgs e)
        {
            Home HomeForm = new Home();
            this.Hide();
            HomeForm.Show();
        }

        private void BtRegister_Click(object sender, EventArgs e)
        {
            Register RegisterForm = new Register();
            this.Hide();
            RegisterForm.Show();
        }

        private void BtSignIn_Click(object sender, EventArgs e)
        {
            SignIn SignInForm = new SignIn();
            this.Hide();
            SignInForm.Show();
        }

        private void AboutUs_Load(object sender, EventArgs e)
        {

        }
    }
}
