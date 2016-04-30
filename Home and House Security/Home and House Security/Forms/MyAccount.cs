﻿using System;
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
    public partial class MyAccount : Form
    {
        public MyAccount(User user)
        {
            InitializeComponent();
            name.Text = user.name;
            username.Text = user.username;
            email.Text = user.email;
            account.Text = user.accountType;
            address.Text = user.address;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
