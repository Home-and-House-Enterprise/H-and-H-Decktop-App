using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_and_House_Security
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void makeAccount_Click(object sender, EventArgs e)
        {
            if (verifyInfo())
            {
                makeNewAccount();
                MessageBox.Show("Welcome "+fname.Text+" "+
                    lname.Text+"!\nPlease log in and setup your new account.");
                this.Hide();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private bool verifyInfo()
        {
            if (fname.Text == "" || lname.Text == "")
            {
                MessageBox.Show("You must have a first and Last Name!");
                return false;
            }

            if (user.Text =="")
            {
                MessageBox.Show("You must have a username!");
                return false;
            }
            if (user.Text.Length < 3)
            {
                MessageBox.Show("Your username must contain atleast 3 character!");
                return false;
            }
            if (pass1.Text.Length<7)
            {
                MessageBox.Show("Your pasword must contain atleast 7 character!");
                return false;
            }

            if (!pass1.Text.Equals(pass2.Text))
            {
                MessageBox.Show("Passwords does not match!");
                return false;
            }

            return true;
        }
        private void makeNewAccount()
        {

        }
    }
}
