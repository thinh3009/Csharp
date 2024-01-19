using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            TenHang hang = new TenHang();
            NganHang bank = new NganHang();
            KhachHang kh=new KhachHang();
            bank.NhapNganHang();
            bank.XuatNganHang();
            DirectoryInfo curr = new DirectoryInfo(".");//lay duong dan hien tai
            Console.WriteLine(curr.FullName);

            string duongdan = "xuathoadon.txt";
            string noidung = (str)bank.XuatNganHang();

            Console.ReadKey();
        }
    }
}
