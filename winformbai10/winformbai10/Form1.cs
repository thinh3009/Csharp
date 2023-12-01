using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformbai10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            chklb.Items.Add("ok con de");

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            chklb.Items.Insert(1, 90);
        }

        private void btnAddRange_Click(object sender, EventArgs e)
        {
            chklb.Items.AddRange(new string[] { "com", "canh", "chao" });
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("so phan tu: " + chklb.Items.Count);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            chklb.Items.Remove("ok");
        }

        private void btnRemoveAt_Click(object sender, EventArgs e)
        {
            chklb.Items.RemoveAt(2);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            chklb.Items.Clear();
        }

        private void btnCheckedIndices_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedIndexCollection indexCollection=chklb.CheckedIndices;
            string strCheck = "";
            foreach(int i in indexCollection)
            {
                strCheck += i + "";

            }
            MessageBox.Show("index ptr dang chon" + strCheck);

        }

        private void btnCheckedItems_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection items = chklb.CheckedItems;
            string checkItems = "";
            foreach (object item in items)
            {
                checkItems += item.ToString() + " ";
            }
            MessageBox.Show(checkItems);

        }

        private void btnGetitemCheck_Click(object sender, EventArgs e)
        {//lay vi tri index
            string strcheck = "";
            for(int i=0;i<chklb.Items.Count;i++)
            {
                if (chklb.GetItemChecked(i))
                {
                    strcheck +=i + " ";
                }
            }
            MessageBox.Show(strcheck);
        }
    }
}
