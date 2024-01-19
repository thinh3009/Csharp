using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace winformPJ
{
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;
        string str= @"Data Source=BDTHINH\SQLEXPRESS;Initial Catalog=portfolio2;Integrated Security=True";
        SqlDataAdapter adapter=new SqlDataAdapter();
        DataTable table=new DataTable();

        void loaddata()
        {
            cmd=conn.CreateCommand();
            cmd.CommandText="select * from hanghoa";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }



        private void frmBanHang_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            loaddata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMasp.ReadOnly = true;
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtMasp.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTensp.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtsoluong.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtdongia.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtthanhtien.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "insert into hanghoa values('" + txtMasp.Text + "','" + txtTensp.Text + "','" + txtsoluong.Text + "','" + txtdongia.Text + "','" + txtthanhtien.Text + "')";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cmd= conn.CreateCommand();
            cmd.CommandText = "delete from hanghoa where masp='"+txtMasp.Text+"'";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "update hanghoa set tensp='"+txtTensp.Text+"',soluong='"+txtsoluong.Text+"',dongia='"+txtdongia.Text+"',thanhtien='"+txtthanhtien.Text+"' where masp='"+txtMasp.Text+"'";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtMasp.Text = "";
            txtTensp.Text = "";
            txtsoluong.Text = "";
            txtdongia.Text = "";
            txtthanhtien.Text = "";
        }
    }
}
