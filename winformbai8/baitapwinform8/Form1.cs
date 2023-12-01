using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitapwinform8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int x= int.Parse(txtSo.Text);
            lstSo.Items.Add(x);

        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong = 0;
            foreach (int i in lstSo.Items)
            {
                tong += i;
            }
            MessageBox.Show("tong la: " + tong);

        }

        private void btnxoaDaucuoi_Click(object sender, EventArgs e)
        {
            lstSo.Items.RemoveAt(0);
            lstSo.Items.RemoveAt(lstSo.Items.Count - 1);
        }

        private void btnXoapt_Click(object sender, EventArgs e)
        {
            while(lstSo.SelectedIndex !=-1)
            {
                lstSo.Items.RemoveAt(lstSo.SelectedIndex);
            }
        }

        private void btnTanglen2_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < lstSo.Items.Count; i++)
            {
                ///Console.WriteLine(i);
                Console.WriteLine(lstSo.Items[i]);
                int k = (int)lstSo.Items[i]+2;
                lstSo.Items[i] = k;


            }
        }

        private void btnBinhPhuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                ///Console.WriteLine(i);
                Console.WriteLine(lstSo.Items[i]);
                int k = (int)lstSo.Items[i] * (int)lstSo.Items[i];
                lstSo.Items[i] = k;


            }
        }

        private void btnSoChan_Click(object sender, EventArgs e)
        {
            lstSo.SelectedIndex = -1;//khong chon gia tri gi la -1
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                
                int k = (int)lstSo.Items[i];
                if (k % 2 == 0)
                {
                    lstSo.SelectedIndex = i;
                }


            }
        }

        private void btnSoLe_Click(object sender, EventArgs e)
        {
            lstSo.SelectedIndex = -1;//khong chon gia tri gi la -1
            for (int i = 0; i < lstSo.Items.Count; i++)
            {

                int k = (int)lstSo.Items[i];
                if (k % 2 != 0)
                {
                    lstSo.SelectedIndex = i;
                }


            }
        }
    }
}
