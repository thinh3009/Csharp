﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformbai14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //code
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //timer1.Enabled = true;
            timer1.Start();
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Stop();
        }
    }
}
