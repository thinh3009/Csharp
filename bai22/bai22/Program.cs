using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tao doi tuong moi ko truyen gia tri
            SinhVien sinhvien1 = new SinhVien();
            SinhVien sinhvien2 = new SinhVien();
            //xuat
            Console.WriteLine(sinhvien1.MaSV);
            Console.WriteLine(sinhvien2.MaSV);
            Console.WriteLine(sinhvien1.TenSV);
            Console.WriteLine("ten sinh vien la: " + sinhvien1.TenSV);
            //tao doi tuong co truyen gia tri
            SinhVien sinhvie3= new SinhVien(3,"thinh ne",20);//method vs suportmethod
            
            Console.WriteLine("sinh vien 3: " + sinhvie3.TenSV);
            //sua doi tuong 
            sinhvie3.MaSV = 334;
            sinhvie3.TenSV = "vy beo";
            Console.WriteLine("sinh vien 3: " + sinhvie3.TenSV);
            Console.WriteLine("masv: " + sinhvie3.MaSV);
            //phuong thuc to string
            Console.WriteLine(sinhvien1.ToString());
            Console.WriteLine(sinhvien2.ToString());
            Console.WriteLine(sinhvien1);
            Console.WriteLine(sinhvie3);
            //chech diem
            sinhvie3.Xuat();

            Console.WriteLine(sinhvie3.TongDiem(1, 2,5));
            //parameter
            Console.WriteLine(sinhvien2.TBketthucHK(1, 6, 7, 5, 7, 5, 8, 5, 4, 3, 3));

            //auto-implement properties
            HocSinh hocsinh1 = new HocSinh();
            hocsinh1.Name = "thinh";
            hocsinh1.Phone = "23423";
            hocsinh1.Mail = "ok.ovm";
            Console.WriteLine(hocsinh1);
            Console.ReadKey();

        }
    }
}
