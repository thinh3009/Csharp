using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapb9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("nhap lua chon: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("1.tim theo ten");
            Console.WriteLine("2.tim theo tac gia");
            Console.WriteLine("3.tim theo nha xuat ban");
            Console.WriteLine("4.tim theo tieu de");
            Console.WriteLine("thoat");
            switch (a)
            {
                case 1:
                    Console.WriteLine("vui long nhap ten");
                    break;
                case 2: Console.WriteLine("vui long nhap tac gia");
                    break;
                case 3: Console.WriteLine("vui long nhap nha xuat ban");
                    break;
                case 4: Console.WriteLine("vui long nhap tieu de");
                    break;
                default: Console.WriteLine("cam on da su dung chuong trnh");
                    break;
            }
            Console.ReadKey(); 
            

        }
    }
}
