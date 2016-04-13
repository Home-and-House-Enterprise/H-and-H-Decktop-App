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
    public partial class Login : Form
    {
        CreateAccount createAccForm = new CreateAccount();
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            createAccForm.ShowDialog(this);
        }

        private void signin_Click(object sender, EventArgs e)
        {
            Message m = HNHWebServer.doJSONPost<Message>("validate-login.php", "username=" + username.Text +
                "&password=" + password.Text);
            Console.WriteLine(m.name);
            if (m.message.Equals("true"))
            {

                this.Hide();
                User mainUser= HNHWebServer.doJSONPost<User>("get-user.php", "username=" + username.Text +
                "&password=" + password.Text);
                ControlPanel cp = new ControlPanel(mainUser);
                cp.Show();
            }
            else{
                MessageBox.Show("Invalide Username or Password!");
            }
        }
    }
}
