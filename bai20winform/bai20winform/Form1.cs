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
namespace bai20winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //tieu de
            saveFileDialog1.Title = "day la tieu de";
            //fillter
            saveFileDialog1.Filter = "text file|*.txt|pdf file|*.pdf|all file|*.*";
            if(saveFileDialog1.ShowDialog()==DialogResult.OK) { //neu co nguoi dung nhap nut save
                File.WriteAllText(saveFileDialog1.FileName,txtNoidung.Text);
            }
            else
            {
                MessageBox.Show("ban chua luu noi dung");
            }
        }
    }
}
