using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    public class TenHang
    {
        public string TenSp { get; set; }

        public string MaSp { get; set; }

        public string DonVi { get; set; }

        public int SoLuong { get; set; }

        public float DonGia { get; set; }

        public float ThanhTien { get; private set; }

        public double Sale()
        {
            return 20.0;
        }

        public double KtraGiamGia()
        {
            if (ThanhTien >= 2000000f)
            {
                Console.WriteLine("gia sau khi giam:");
                return (double)ThanhTien - Sale() * (double)ThanhTien / 100.0;
            }
            Console.WriteLine("Bạn không được giảm giá!!");
            return ThanhTien;
        }

        public void NhapHang()
        {
            Console.WriteLine("Nhập tên sản phẩm: ");
            TenSp = Console.ReadLine();
            Console.WriteLine("Nhập mã sản phẩm: ");
            MaSp = Console.ReadLine();
            Console.WriteLine("Đơn vị: ");
            DonVi = Console.ReadLine();
            Console.WriteLine("Số lượng: ");
            SoLuong = int.Parse(Console.ReadLine());
            Console.WriteLine("Đơn giá: ");
            DonGia = float.Parse(Console.ReadLine());
            ThanhTien = (float)SoLuong * DonGia;
        }

        public void XuatHang()
        {
            Console.WriteLine("Thông tin sản phẩm:");
            Console.WriteLine("Tên sản phẩm: " + TenSp);
            Console.WriteLine("Mã sản phẩm: " + MaSp);
            Console.WriteLine("Đơn vị: " + DonVi);
            Console.WriteLine($"Số lượng: {SoLuong}");
            Console.WriteLine($"Đơn giá: {DonGia}");
            Console.WriteLine($"Thành tiền: {ThanhTien}");
        }
    }

}
