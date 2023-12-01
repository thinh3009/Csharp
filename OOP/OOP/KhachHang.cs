using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class KhachHang:NganHang
    {
        private string tenKhachHang;
        private string maDonHang;
        private int soDth;
        private string diaChi;
        private string soTK;
        private string hinhThucThanhToan;
        private float soTienTra;
        private string tenNganHang;
        public KhachHang(string tenKhachHang, string maDonHang, int soDth, string diaChi, string soTK, string hinhThucThanhToan, float soTienTra,string tenNganHang) : base(tenNganHang, soTK)
        { 
            this.tenKhachHang= tenKhachHang;
            this.maDonHang= maDonHang;
            this.soDth= soDth;
            this.diaChi=diaChi;
            this.soTK= soTK;
            this.hinhThucThanhToan= hinhThucThanhToan;
            this.soTienTra= soTienTra;
            this.tenNganHang= tenNganHang;
        }
        //khai bao properties
        public string TenKhachHang
        {
            get { return this.tenKhachHang; }
            set { tenKhachHang = value; }
        }
        public string MaDonHang
        {
            get { return this.maDonHang; }
            set { maDonHang = value; }
        }
        public int SoDth
        {
            get { return this.soDth; }
            set { soDth = value; }
        }
        public string DiaChi
        {
            get { return this.diaChi; }
            set { this.diaChi = value;}
        }
        
        public string HinhThucThanhToan
        {
            get { return this.hinhThucThanhToan ; }
            set { hinhThucThanhToan = value; }
        }
        public float SoTienTra
        {
            get { return this.soTienTra; }
            set { soTienTra = value; }
        }
        
        //methods
        private void XuatHoaDon()
        {
            Console.Write("ten:" + tenKhachHang);
            Console.Write("ma don: " + maDonHang);
            Console.Write("so dien thoai: " + soDth);
            Console.Write("dia chi: " + diaChi);
            Console.Write("so tai khoan: " + soTK);
            Console.Write("hinh thuc thanh toan: " + hinhThucThanhToan);
            Console.Write("so tien tra: " + soTienTra);
            Console.Write("ten ngan hang: " + tenNganHang);
        }
        public void DoiThongTinKhach(ref string tenKhachHang, ref string maDonHang, ref int soDth, ref string diaChi,
                                     ref string hinhThucThanhToan)
        {

            Console.WriteLine("ban muon doi thoong tin cua ai: " +
                "1. ten khach hang" +
                "2. ma don hang" +
                "3. so dien thoai" +
                "4. dia chi" +
                "5. hinh thuc thanh toan");
            int chon=int.Parse(Console.ReadLine());//nhap input gia tri
            if (chon == 1)
            {
                Console.WriteLine("sua ten khach hang: ");
                tenKhachHang=Console.ReadLine();
                Console.WriteLine("ten khach moi la: " + tenKhachHang);
            }
            else if(chon==2)
            {
                Console.WriteLine("sua ma don hang hang: ");
                maDonHang = Console.ReadLine();
                Console.WriteLine("ten khach moi la: " + maDonHang);
            }
            else if(chon==3)
            {
                Console.WriteLine("sua so dien thoai: ");
                soDth = int.Parse(Console.ReadLine());
                Console.WriteLine("ten khach moi la: " + soDth);
            }
            else if(chon==4)
            {
                Console.WriteLine("sua dia chi: ");
                diaChi = Console.ReadLine();
                Console.WriteLine("dia chi moi la: " + diaChi);
            }
            
            else if(chon==5)
            {
                Console.WriteLine("sua hinh thuc thanh toan hang: ");
                hinhThucThanhToan = Console.ReadLine();
                Console.WriteLine("hinh thuc moi la: " + hinhThucThanhToan);
            }
            
            else
            {
                XuatHoaDon();
            }
        }

    }
}
