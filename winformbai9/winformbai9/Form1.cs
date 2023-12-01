using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformbai9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cboADD.Items.Add("ok");
            cboADD.Items.Add("oh no");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            cboADD.Items.Insert(0, "ditmemay");
        }

        private void btnselectindex_Click(object sender, EventArgs e)
        {
            MessageBox.Show("index ban chon: " + cboADD.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("index ban chon: " + cboADD.SelectedItem);
        }

        private void btnCOunt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("so phan tu cbo: " + cboADD.Items.Count);
        }

        private void btnAddRange_Click(object sender, EventArgs e)
        {
            cboADD.Items.AddRange(new string[] {"pt1","pt2","pt3"});
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            cboADD.Items.Remove("com");
        }

        private void removeAt_Click(object sender, EventArgs e)
        {
            cboADD.Items.RemoveAt(0);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboADD.Items.Clear();
        }
    }
}
