using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformbai5
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (chkCoPhim.Checked)
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban muon thoat khong", "Thong bao",MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
               Close();
            }
            
        }

        private void form1_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
           
        }

        private void lblOutPut_TextChanged(object sender, EventArgs e)
        {
            lblOutPut.Text = txtNhapTen.Text;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked)
            {
                lblOutPut.ForeColor= radRed.ForeColor;
            }
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked)
            {
                lblOutPut.ForeColor= radGreen.ForeColor;
            }
        }

        private void Radblue_CheckedChanged(object sender, EventArgs e)
        {
            if (Radblue.Checked)
            {
                lblOutPut.ForeColor=Radblue.ForeColor;
            }
        }

        private void RadBrown_CheckedChanged(object sender, EventArgs e)
        {
            if (RadBrown.Checked)
            {
                lblOutPut.ForeColor = RadBrown.ForeColor;
            }
        }

        private void chkIndam_CheckedChanged(object sender, EventArgs e)
        {
            lblOutPut.Font=new Font(
                lblOutPut.Font.Name,
                lblOutPut.Font.Size,
                lblOutPut.Font.Style ^FontStyle.Bold);
        }

        private void chkInNghieng_CheckedChanged(object sender, EventArgs e)
        {
            lblOutPut.Font = new Font(lblOutPut.Font.Name,
                lblOutPut.Font.Size,
                lblOutPut.Font.Style^FontStyle.Italic);
        }

        private void chkGach_CheckedChanged(object sender, EventArgs e)
        {
            lblOutPut.Font = new Font(lblOutPut.Font.Name,
                lblOutPut.Font.Size,
                lblOutPut.Font.Style ^FontStyle.Underline);
        }
    }
}
