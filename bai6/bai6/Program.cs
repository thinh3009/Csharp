using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool kq;
            int a = 6, b = 10;
            kq = (a != b) || (a < 3);
            Console.WriteLine("gia tri kq: " + kq);
            kq = (a != b) && (a < 3);
            Console.WriteLine("gia tri kq: " + kq);
          
            //baitap
            float chieudai;
            float chieurong;
            Console.Write("nhap chieu dai: ");
            chieudai = float.Parse(Console.ReadLine()); 
            Console.Write("nhap chieu rong: ");
            chieurong = float.Parse(Console.ReadLine());
            float dientich = chieudai * chieurong;
            float chuvi = (chieudai + chieurong) * 2;
            Console.WriteLine("dien tich hinh chu nhat: " + dientich);
            Console.WriteLine("chu vi hinh chu nhat: "+chuvi);
            Console.ReadLine();
        }
    }
}
