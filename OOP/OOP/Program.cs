using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            /*Console.Write("Nhap ten ngan hang: ");
            string tenNgaHang=Console.ReadLine();

            Console.Write("Nhap stk: ");
            string soTK=Console.ReadLine();

            Console.Write("nhap ten cong ty: ");
            string tenCty=Console.ReadLine();
            Console.Write("nhap dia chi: ");
            string diaChi = Console.ReadLine();
            Console.Write("nhap ma so thue: ");
            string maSoThue = Console.ReadLine();
            Console.Write("hinh thuc thanh toan: ");
            string hinhThucThanhToan = Console.ReadLine();
            Console.Write("web: ");
            string webSite = Console.ReadLine();
            
            
            CongTy cty = new CongTy(tenNgaHang,soTK,tenCty,diaChi,maSoThue,hinhThucThanhToan,webSite);
            TenHang hang= new TenHang(tenSp, maSp, donVi, soLuong,  donGia,  thanhTien);
            NganHang bank = new NganHang(tenNgaHang, soTK);
            cty.XuatNganHang();
            cty.XuatCongty();
            bank.XuatNganHang();*/
            TenHang hang= new TenHang();
            hang.NhapHang();
            hang.XuatHang();
            double tinh = hang.KtraGiamGia();
            Console.WriteLine(tinh);
            Console.ReadKey();
            
        }
    }
}
