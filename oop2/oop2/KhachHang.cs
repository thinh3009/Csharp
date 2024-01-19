using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    public class KhachHang : NganHang
    {
        private string tenKhachHang { get; set; }
        private string maDonHang { get; set; }
        private string soDth { get; set; }
        private string diaChi { get; set; }
        //private string soTK { get; set; }
        private string hinhThucThanhToan { get; set; }
        private float soTienTra { get; set; }
        //private string tenNganHang { get; set; }
        
       
        //methods
        public void NhapKH()
        {
            Console.WriteLine("nhap ten khach hang: ");
            tenKhachHang = Console.ReadLine();
            Console.WriteLine("nhap ma don hang");
            maDonHang = Console.ReadLine();
            Console.WriteLine("so dien thoai: ");
            soDth=Console.ReadLine();
            Console.WriteLine("dia chi");
            diaChi = Console.ReadLine();
            /*Console.WriteLine("so tai khoan");
            soTK = Console.ReadLine();*/
            Console.WriteLine("hinh thuc thanh toan");
            hinhThucThanhToan = Console.ReadLine();
            Console.WriteLine("so tien tra");
            soTienTra=float.Parse(Console.ReadLine());
            /*Console.WriteLine("ten ngan hang");
            tenNganHang=Console.ReadLine();*/


        }
        public void XuatHoaDon()
        {
            Console.WriteLine("ten:" + tenKhachHang);
            Console.WriteLine("ma don: " + maDonHang);
            Console.WriteLine("so dien thoai: " + soDth);
            Console.WriteLine("dia chi: " + diaChi);
            //Console.Write("so tai khoan: " + soTK);
            Console.WriteLine("hinh thuc thanh toan: " + hinhThucThanhToan);
            Console.WriteLine("so tien tra: " + soTienTra);
            //Console.Write("ten ngan hang: " + tenNganHang);
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
            int chon = int.Parse(Console.ReadLine());//nhap input gia tri
            if (chon == 1)
            {
                Console.WriteLine("sua ten khach hang: ");
                tenKhachHang = Console.ReadLine();
                Console.WriteLine("ten khach moi la: " + tenKhachHang);
            }
            else if (chon == 2)
            {
                Console.WriteLine("sua ma don hang hang: ");
                maDonHang = Console.ReadLine();
                Console.WriteLine("ten khach moi la: " + maDonHang);
            }
            else if (chon == 3)
            {
                Console.WriteLine("sua so dien thoai: ");
                soDth = int.Parse(Console.ReadLine());
                Console.WriteLine("ten khach moi la: " + soDth);
            }
            else if (chon == 4)
            {
                Console.WriteLine("sua dia chi: ");
                diaChi = Console.ReadLine();
                Console.WriteLine("dia chi moi la: " + diaChi);
            }

            else if (chon == 5)
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
