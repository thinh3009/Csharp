using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("xin cam on",
                "thong bao",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
                );
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            /*DialogResult result = MessageBox.Show("ban co muon thoat?",
                "thong bao",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Close();
            }
            else if(result==DialogResult.No)
            {
                MessageBox.Show("ok xai tiep di", "thong bao");
            }*/
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("ban co chac muon thoat", "thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
