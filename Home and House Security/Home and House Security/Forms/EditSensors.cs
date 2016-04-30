using Home_and_House_Security.Data_Entities;
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
    public partial class EditSensors : Form
    {
        public ulong id;
        private ulong fpID;
        public ulong FloorPlanID
        {
            get {
                return fpID;
            }
            set
            {
                fpID = value;
                updateList();
            }
        }
        Sensor[] sensors;
        public EditSensors()
        {
            InitializeComponent();
            updateList();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void update_Click(object sender, EventArgs e)
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
                int enabledValue = 1;
                if (enabled.Checked)
                {
                    enabledValue = 1;
                }
                else
                {
                    enabledValue = 0;
                }
                Message m = HNHWebServer.doJSONPost<Message>("update-sensor.php", "name=" +
                sensorName.Text + "&id=" + id + "&fpid=" + fpID + "&xpos=" + fpXpos + "&ypos=" + fpYpos
                 + "&enabled="+ enabledValue);
                if (m != null)
                {
                    if (m.status == "success")
                    {
                        updateList();
                        MessageBox.Show("Sensor Updated successful!");
                    }
                }
            }
        }

        private void select_Click(object sender, EventArgs e)
        {
            if (sensors[slist.SelectedIndex] != null) {
                this.id = sensors[slist.SelectedIndex].id;
                xPos.Text = sensors[slist.SelectedIndex].xpos + "";
                yPos.Text = sensors[slist.SelectedIndex].ypos + "";
                sensorName.Text = sensors[slist.SelectedIndex].name;
                enabled.Checked = sensors[slist.SelectedIndex].enabled;
               // if (sensors[slist.SelectedIndex].enabled)
               //  {

                //  }
            }
            else
            {
                MessageBox.Show("Must select a Sensor!");
            }
                    
        }

        private void updateList()
        {
            Message m = HNHWebServer.doJSONPost<Message>("get-sensors.php", "fpid=" + fpID);
            if (m != null)
            {
                if (m.status == "success")
                {
                    slist.Items.Clear();
                    foreach (Sensor s in m.sensors)
                    {
                        slist.Items.Add(s.name);
                    }
                    sensors = m.sensors;
                }
            }

        }
    }
}
