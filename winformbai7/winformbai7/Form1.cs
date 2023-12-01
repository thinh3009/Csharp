using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformbai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            bool check= true;
            errorProvider1.Clear();
            if (txtphone.Text=="")
            {
               
                
                errorProvider1.SetError(txtphone, "ban chua nhap phone");
                check = false;
            }
            //tuoi
            int tuoi;
            if(int.TryParse(txtage.Text, out tuoi)==false ) {
                errorProvider1.SetError(txtage, "sai dinh dang");
                check=false;
            }
            else {
                if (tuoi < 17)
                {
                    errorProvider1.SetError(txtage, "tuoi phai lon hon 17");
                    check = false;
                }
            }
            //kiem tra ngay
            if(dtpDK.Value.DayOfWeek==DayOfWeek.Monday)
            {
                errorProvider1.SetError(dtpDK, "thu 2 khong co phim");
                check = false;
            }
            if(check==true) {
                MessageBox.Show("dang ky thanh cong", "thong bao");
            }
        }
    }
}
