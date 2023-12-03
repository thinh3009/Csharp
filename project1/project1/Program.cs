using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b=6;
            int c = a + b;
            Console.WriteLine(c);
            int d;
            Console.WriteLine("nhap so luong phan tu: ");
            d=int.Parse(Console.ReadLine());
            int tong = 0;
            for (int i=0; i <= d; i++)
            {
                tong = tong + i;
            }
            Console.WriteLine("tong la: " + tong);
            Console.ReadKey();
        }
    }
}
