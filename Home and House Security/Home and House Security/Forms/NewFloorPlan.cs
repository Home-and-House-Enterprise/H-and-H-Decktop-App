using Home_and_House_Security;
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
    public partial class NewFloorPlan : Form
    {
        OpenFileDialog openFileDialog1;
        private ulong id;

        public NewFloorPlan(ulong id)
        {
            InitializeComponent();
            fpImage.Image = null;
            this.id = id;
            // Create an instance of the open file dialog box.
            openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Process input if the user clicked OK.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image picture = Image.FromFile(openFileDialog1.FileName);
                fpImage.Image = picture;            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fpImage.Image == null)
            {
                MessageBox.Show("Must Choose An Image!");
                return;
            }
            if (fpname.Text.Trim() == "")
            {
                MessageBox.Show("Floor Plan must Have a name!");
                return;
            }
            MediaStorageConnector ms = new MediaStorageConnector();
            string originalName = openFileDialog1.FileName;
            FileInfo file = new FileInfo(originalName);
            //new name eliminate duplicate names on server
            string newName = file.Directory.FullName+"\\"+id+ 
                string.Format("{0:yyyy-MM-dd_hh-mm-ss-tt}", DateTime.Now)+file.Extension;
            //Console.WriteLine("old: "+originalName +" | new: "+ newName);
            FileInfo copy = new FileInfo(newName);
            Message m = HNHWebServer.doJSONPost<Message>("create-floor-plan.php", "name="+
                fpname.Text+"&id="+id+"&picture="+copy.Name);
            if (m != null)
            {
                if (m.status == "success")
                {
                    File.Copy(originalName, newName);//renames file for upload
                    ms.sendImage(newName);
                    File.Delete(newName);//puts the original name back
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Creating Floor Plan\n"+
                        "Check for duplicate names!\nFloor Plans can't have duplicate names!");
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
