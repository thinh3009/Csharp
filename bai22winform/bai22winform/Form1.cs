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
namespace bai22winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbrowser_Click(object sender, EventArgs e)
        {
            //check nguoi dung da chon thu muc chua
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtbrowser.Text = folderBrowserDialog1.SelectedPath;
            }
            else
            {
                MessageBox.Show("ban chua chon thu muc");
            }
        }

        private void btnrun_Click(object sender, EventArgs e)
        {
            if (txtbrowser.Text != "")
            {
                //check thu muc co ton tai hay khong, neu khong bao loi
                string path=txtbrowser.Text;//tao duong dan khi nhap textbox
                if (Directory.Exists(path))
                {
                    //duyet

                    for (int i = 0; i < 10; i++)
                    {
                        //them file hang loat
                        string pathCreate = path + @"teptin"+i+".txt";

                        //Console.WriteLine(pathCreate);
                        FileInfo f = new FileInfo(pathCreate);
                        f.Create(); 
                        
                    }
                    MessageBox.Show("tao thanh cong");
                }
                else
                {
                    MessageBox.Show("duong dan khong ton tai");
                }
                
            }
            else
            {
                MessageBox.Show("ban chua nhap duong dan");
            }
        }

        private void btnrun2_Click(object sender, EventArgs e)
        {
            if (txtbrowser.Text != "")
            {
                //check thu muc co ton tai hay khong, neu khong bao loi
                string path = txtbrowser.Text;//tao duong dan khi nhap textbox
                if (Directory.Exists(path))
                {
                    //duyet

                    for (int i = 0; i < 10; i++)
                    {
                        //them thu muc hang loat
                        string pathCreate = path + @"thumuc" + i + ".txt";

                        //Console.WriteLine(pathCreate);
                        DirectoryInfo f = new DirectoryInfo(pathCreate);
                        f.Create();

                    }
                    MessageBox.Show("tao thanh cong");
                }
                else
                {
                    MessageBox.Show("duong dan khong ton tai");
                }

            }
            else
            {
                MessageBox.Show("ban chua nhap duong dan");
            }
        }
    }
}
