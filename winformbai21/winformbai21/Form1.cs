using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace winformbai21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbrower_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtthumuc.Text=folderBrowserDialog1.SelectedPath;//khi chon xong se gui ve o textbox

            }
            else
            {
                MessageBox.Show("ban chua chon duong dan");
            }
        }
    }
}
