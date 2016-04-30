using Home_and_House_Security.Data_Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_and_House_Security.Forms
{
    public partial class ViewCameras : Form
    {
        Camera[] cameras = new Camera[4];
        MediaStorageConnector media;
        public ViewCameras()
        {
            InitializeComponent();
            media = new MediaStorageConnector();
            getCameras();
            updateList();
        }

        private void selectfp_Click(object sender, EventArgs e)
        {
            if (camlist.SelectedIndex >= 0)
            {
                string file = cameras[camlist.SelectedIndex].currentImage;
                FileInfo f = new FileInfo(file);
                if (!f.Exists)
                    camImage.Image = media.getImage(file);
                else
                    camImage.Image = Image.FromFile(file);
            }
            else
            {
                MessageBox.Show("Must aelect a camera!");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateList()
        {
            camlist.Items.Clear();
           
            foreach (Camera c in cameras)
            {
                camlist.Items.Add(c.name);
            }
            
        }
        private void getCameras()
        {
            cameras[0] = new Camera();
            cameras[0].name = "Front Door";
            cameras[0].currentImage = "frontdoor.jpg";
            cameras[1] = new Camera();
            cameras[1].name = "Back Door";
            cameras[1].currentImage = "backdoor.jpg";
            cameras[2] = new Camera();
            cameras[2].name = "Kitchen";
            cameras[2].currentImage = "kitchen.jpg";
            cameras[3] = new Camera();
            cameras[3].name = "Living Room";
            cameras[3].currentImage = "livingroom.jpg";

        }
    }
}
