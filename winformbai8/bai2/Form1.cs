using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            sinhvien sv = new sinhvien();
            sv.ma = int.Parse(txtMa.Text);
            sv.ten=txtTen.Text;
            string s = sv.ma + " - " + sv.ten;
            lstDS.Items.Add(s);
        }

        private void ls_Click(object sender, EventArgs e)
        {
            lstDS.Items.Clear();
        }
    }
}
