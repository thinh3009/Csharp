using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitaap
{
    public partial class Form1 : Form
    {
        int TienNguoiChoi = 100;
        Random rd=new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnQuayso_Click(object sender, EventArgs e)
        {
            if (TienNguoiChoi < 20)
            {
                MessageBox.Show("ban khong du tien choi, nap them di");
            }
            else
            {
                //tru tien
                TienNguoiChoi = TienNguoiChoi - 20;
                txtTienNguoiCHoi.Text=TienNguoiChoi.ToString();
                //start time
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl1.Text = rd.Next(0, 8).ToString();
            lbl2.Text = rd.Next(0, 9).ToString();
            lbl3.Text = rd.Next(0, 10).ToString();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (lbl1.Text == "7")
            {
                TienNguoiChoi += 30;
            }
            if(lbl2.Text == "7")
            {
                TienNguoiChoi += 40;
            }
            if(lbl3.Text == "7")
            {
                TienNguoiChoi += 50;
            }
            txtTienNguoiCHoi.Text = TienNguoiChoi + "";
        }

        private void btngamemoi_Click(object sender, EventArgs e)
        {
            TienNguoiChoi = 100;
            txtTienNguoiCHoi.Text = TienNguoiChoi + "";
        }
    }
}
