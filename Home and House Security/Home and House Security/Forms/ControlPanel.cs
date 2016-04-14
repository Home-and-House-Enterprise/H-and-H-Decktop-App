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
        User user;
        public ControlPanel(User userIn)
        {
            InitializeComponent();
            user = userIn;
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
