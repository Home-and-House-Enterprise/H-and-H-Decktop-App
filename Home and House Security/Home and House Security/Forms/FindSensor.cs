using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_and_House_Security.Forms
{
    public partial class FindSensor : Form
    {
        public ulong id { get; set; }
        public ulong fpID { get; set; }
        public FindSensor(ulong fpID)
        {
            InitializeComponent();
            this.fpID = fpID;
            id = 0;
        }

        private void search_Click(object sender, EventArgs e)
        {
            Message m = HNHWebServer.doJSONPost<Message>("find-sensor.php", "id=" + sensorid.Text);
            if (m != null)
            {
                if (m.status == "success")
                {
                    display.BackColor = Color.Green;
                    display.Text = "valid";
                    id = Convert.ToUInt64(sensorid.Text);
                }
                if(m.status == "failed")
                {
                    display.BackColor = Color.Red;
                    display.Text = "invalid";
                    id = 0;
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                int fpXpos, fpYpos;
                try
                {
                    fpXpos = Convert.ToInt32(xPos.Text);
                    fpYpos = Convert.ToInt32(yPos.Text);
                }
                catch (FormatException f)
                {
                    MessageBox.Show("Sensor Must have a varlid X position\n" +
                        "and Y position on the floor plan!");
                    return;
                }
                if (name.Text.Trim() == "")
                {
                    MessageBox.Show("Sensor must Have a name!");
                    return;
                }
                Message m = HNHWebServer.doJSONPost<Message>("update-sensor.php", "name=" +
                sensorName.Text + "&id=" + id + "&fpid=" + fpID + "&xpos=" + fpXpos + "&ypos=" + fpYpos);
                if (m != null)
                {
                    if (m.status == "success")
                    {
                        MessageBox.Show("Sensor Added successfully!");
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
