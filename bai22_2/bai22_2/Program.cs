using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai22_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NhanVien nv1= new NhanVien();
            nv1.TenNV = "thinh ne";
            nv1.MaNV = 1;
            Console.WriteLine("ten nhan vien la: " + nv1.TenNV+"ma: "+nv1.MaNV);
            Console.WriteLine("nhan vien 1 luong: "+nv1.TinhLuong());
            
            NhanVienHanhChinh hc1=new NhanVienHanhChinh();
            hc1.TenNV = "vy beo";
            hc1.MaNV = 69;
            Console.WriteLine("ten nv: " + hc1.TenNV);
            Console.WriteLine("luong nhan vien hanh chinh: "+hc1.TinhLuong());//ke thua method

            NhanVienDiCa nvca=  new NhanVienDiCa();
            nvca.TenNV = "ok con de";
            nvca.MaNV = 123;
            nvca.Ca = "ca dem";
            Console.WriteLine("ten nhan vien la: " + nvca.TenNV + "ma: " + nvca.MaNV+nvca.Ca);
            //overriding method
            Console.WriteLine("nhan vien di ca co luong: " + nvca.TinhLuong());

            Console.WriteLine(nv1.ThuongCong(26));
            Console.WriteLine(hc1.ThuongCong(26));
            Console.WriteLine(nvca.ThuongCong(26));
            Console.ReadKey();

        }
    }
}
