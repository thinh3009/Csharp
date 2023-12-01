using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai6Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult reslut = MessageBox.Show("ban co muon thoat", "canh bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reslut == DialogResult.Yes)
            {
                Close();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (picdau.Visible == false)
            {
                btnclick.Text = txtName.Text +"mat mat";
            }
            else
            {
                btnclick.Text=txtName.Text+ "co mat";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picdau.Visible = false;
            picthan.Visible = true;
        }

        private void btnclick_Click(object sender, EventArgs e)
        {
            if(picthan.Visible == false)
            {
                picdau.Visible = true;
                picthan.Visible = false;
            }
            else
            {
                picdau.Visible = false;
                picthan.Visible = true;
            }

        }
    }
}
