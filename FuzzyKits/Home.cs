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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TabAll_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtHome_Click(object sender, EventArgs e)
        {

        }

        private void BtSignIn_Click(object sender, EventArgs e)
        {
            SignIn SignInForm = new SignIn();
            this.Hide();
            SignInForm.Show();
        }

        private void BtRegister_Click(object sender, EventArgs e)
        {
            Register RegisterForm = new Register();
            this.Hide();
            RegisterForm.Show();
        }

        private void BtAboutUs_Click(object sender, EventArgs e)
        {
            AboutUs AboutUsForm = new AboutUs();
            this.Hide();
            AboutUsForm.Show();
        }
    }
}
