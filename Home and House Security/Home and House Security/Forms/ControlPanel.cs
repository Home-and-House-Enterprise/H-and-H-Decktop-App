using Home_and_House_Security.Data_Controllers;
using Home_and_House_Security.Forms;
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
    public partial class ControlPanel : Form
    {
        Login main;
        FloorPlans fp;
        User user;
        HnHServerConnector server;
        bool armed = false;
        public ControlPanel(Login main,User userIn)
        {
            InitializeComponent();
            user = userIn;
            fp = new FloorPlans(user);
            server = new HnHServerConnector();
            this.main = main;
            server.init(user.id);
            //get current status armed/disarmed
            this.FormClosing += Form1_FormClosing;
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {

        }

        private void viewfp_Click(object sender, EventArgs e)
        {
            fp.ShowDialog(this);
        }

        private void arm_Click(object sender, EventArgs e)
        {
            Message m = new Message();
            if (armed== false)
            {
                m.messageType = "update";
                m.type = "systemStatus";
                m.value = "arm";
                m.id = user.id;
                server.send(m);
                arm.Text = "DISARM SYSTEM!";
                armed = true;
            }
            else
            {
                m.messageType = "update";
                m.type = "systemStatus";
                m.value = "disarm";
                m.id = user.id;
                server.send(m);
                arm.Text = "ARM SYSTEM!";
                armed = false;
            }


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            server.close();
            main.Show();
        }

        private void contact_Click(object sender, EventArgs e)
        {
            new ContactSupportForm().ShowDialog(this);
        }

        private void myAccount_Click(object sender, EventArgs e)
        {
            new MyAccount(user).ShowDialog(this);
        }

        private void cameras_Click(object sender, EventArgs e)
        {
            new ViewCameras().ShowDialog(this);
        }
    }

}
