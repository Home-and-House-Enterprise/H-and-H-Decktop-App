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
                Message m=makeNewAccount();
                if (m.message.Equals("false"))
                {
                    MessageBox.Show("Error occured will makiing your account!");
                }
                else
                {
                    MessageBox.Show("Welcome " + fname.Text + " " +
                        lname.Text + "!\nPlease log in and setup your new account.");
                    this.Hide();
                }
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
            if (user.Text.Contains(" "))
            {
                MessageBox.Show("Your username can not contain spaces as a character!");
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
            Message m = HNHWebServer.doJSONPost<Message>("check-user-availability.php", "name="+user.Text);
            Console.WriteLine(m.message);
            Console.WriteLine(m.type);
            if (!m.message.Equals("false"))
            {
                MessageBox.Show("Username already taken!");
                return false;
            }

            return true;
        }
        private Message makeNewAccount()
        {
            Message m = HNHWebServer.doJSONPost<Message>("create-user.php", "name=" + fname.Text+" "+
                lname.Text+ "&username=" + user.Text+ "&password=" + pass1.Text);
            return m;
        }
    }
}
