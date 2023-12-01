using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTrai_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection items= chklbTrai.CheckedItems;
            foreach(var i in items)
            {
                Console.WriteLine(i);
                chklbPhai.Items.Add(i);
            }
            //duyet de xoa trai
            foreach(string s in chklbPhai.Items)
            {
                chklbTrai.Items.Remove(s);
            }
        }

        private void btnTrai2_Click(object sender, EventArgs e)
        {
            chklbPhai.Items.AddRange(chklbTrai.Items);
            //xoa het ben trai
            chklbTrai.Items.Clear();
        }

        private void btnPhai_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection items = chklbPhai.CheckedItems;
            foreach (var i in items)
            {
                Console.WriteLine(i);
                chklbTrai.Items.Add(i);
            }
            //duyet de xoa trai
            foreach (string s in chklbTrai.Items)
            {
                chklbPhai.Items.Remove(s);
            }
        }

        private void btnPhai2_Click(object sender, EventArgs e)
        {
            chklbTrai.Items.AddRange(chklbPhai.Items);
            //xoa het ben trai
            chklbPhai.Items.Clear();
        }
    }
}
