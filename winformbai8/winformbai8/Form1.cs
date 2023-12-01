using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformbai8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            lstDS.Items.Add("item 69");
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int a = lstDS.Items.Count;
            MessageBox.Show("so phan tu la: " + a);
        }

        private void btnindex_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lstDS.Items[0].ToString());
        }

        private void btnremoveAt_Click(object sender, EventArgs e)
        {
            lstDS.Items.RemoveAt(0);
        }

        private void selectedindice_Click(object sender, EventArgs e)
        {
            foreach(int i in lstDS.SelectedIndices)
            {
                Console.WriteLine(i);
            }
            //tra ve gia tri phan tu dau tien trong list dc chon
            Console.WriteLine(lstDS.SelectedIndices[0]);
            //dem
            Console.WriteLine(lstDS.SelectedIndices.Count);
        }

        private void bntGan_Click(object sender, EventArgs e)
        {
            lstDS.Items[0] = "okdime";
        }

        private void btnSelectedIndex_Click(object sender, EventArgs e)
        {
            MessageBox.Show("index ban chon" + lstDS.SelectedIndex, "thongbao");
        }
    }
}
