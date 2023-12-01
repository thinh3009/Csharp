using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformb1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong;
            
            tong=int.Parse(txtSoNguyena.Text)+int.Parse(txtSoNguyenb.Text);
            lblKetQua.Text = txtSoNguyena.Text+" "+"+"+txtSoNguyenb.Text+"="+ tong + "";//cong chuoi rong de hien so
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            int tong;
            
            tong = int.Parse(txtSoNguyena.Text) - int.Parse(txtSoNguyenb.Text);
            lblKetQua.Text = txtSoNguyena.Text + " " + "-" + txtSoNguyenb.Text + "=" + tong + "";//cong chuoi rong de hien so
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ban chac muon reset?", "thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lblKetQua.Text = " ";
                txtSoNguyena.Text = " ";
                txtSoNguyenb.Text = " ";
            }
            
        }
    }
}
