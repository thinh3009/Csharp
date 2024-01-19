using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformPJ
{
    public partial class frmLogin : Form
    {
        public static frmLogin instance;
        public frmLogin()
        {
           
            InitializeComponent();
            instance =this;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn=new SqlConnection(@"Data Source=BDTHINH\SQLEXPRESS;Initial Catalog=portfolio2;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = txtTK.Text;
                string mk=txtMK.Text;
                string sql = "select * from quanly where taikhoan= '"+tk+"' and mk='"+mk+"' ";
                SqlCommand cmd=new SqlCommand(sql, conn);
                SqlDataReader data= cmd.ExecuteReader();
                if (data.Read()==true) {
                    MessageBox.Show("dang nhap thanh cong", "thong bao");
                    frmBanHang formBanhang = new frmBanHang();
                    formBanhang.Show();
                }
                else
                {
                    MessageBox.Show("sai tk or mk", "thong bao");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("loi ket noi");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
    }
}
