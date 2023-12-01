using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            //check tieu de
            openfile.Title = "mo file ne ";
            //check dieu kien mo rong
            openfile.Filter = "file anh| *.jpg;*.gif;*.png|all file|*.*";
            //check nguoi dung da chon flie hay chua
            if(openfile.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(openfile.FileName);
                //MessageBox.Show(openfile.SafeFileName);
                pictureBox1.Image = Image.FromFile(openfile.FileName);

            }
            openfile.ShowDialog();

        }
    }
}
