using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformbai17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lvsp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvsp.SelectedItems.Count > 0)
            {
                ListViewItem item = lvsp.SelectedItems[0];
                string ma = item.SubItems[0].Text;
                string ten = item.SubItems[1].Text;
                string gia = item.SubItems[2].Text;
                //MessageBox.Show(ma+"/"+ten+"/"+gia);
                txtMa.Text = ma;
                txtName.Text = ten;
                txtName.Text = gia;
            }
        }

        private void lvsp_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != -1)
            {
                ColumnHeader cot = lvsp.Columns[e.Column];
                MessageBox.Show("cot ban chon la: " + cot.Text);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //phai khoi tao o dau dong
            ListViewItem lv1=new ListViewItem(txtMa.Text);
            //them cac otiep theo
            lv1.SubItems.Add(txtName.Text);
            lv1.SubItems.Add(txtGia.Text);
            lvsp.Items.Add(lv1);
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            while(lvsp.SelectedItems.Count > 0)
            {

                lvsp.Items.RemoveAt(lvsp.SelectedItems[0].Index);
                
            }
        }

        private void btnrv_Click(object sender, EventArgs e)
        {
            while(lvsp.SelectedItems.Count>0)
            {
                lvsp.Items.Remove(lvsp.SelectedItems[0]);
                MessageBox.Show("da xoa");
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (lvsp.SelectedItems.Count > 0)
            {
                ListViewItem lv1 = lvsp.SelectedItems[0];
                lv1.SubItems[0].Text = txtMa.Text;
                lv1.SubItems[1].Text = txtName.Text;
                lv1.SubItems[2].Text = txtGia.Text;
            }
        }
    }
}
