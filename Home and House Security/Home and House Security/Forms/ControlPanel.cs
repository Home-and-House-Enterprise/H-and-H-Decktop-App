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
        FloorPlans fp;
        User user;
        HnHServerConnector server;
        bool armed = false;
        public ControlPanel(User userIn)
        {
            InitializeComponent();
            user = userIn;
            fp = new FloorPlans();
            server = new HnHServerConnector();
            server.init(user.id);
            //get current status armed/disarmed
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
    }
}
