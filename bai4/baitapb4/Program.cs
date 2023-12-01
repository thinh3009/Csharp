using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapb4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("nhap a");
            a=int.Parse(Console.ReadLine());
            int a1=a += 3;
            int a2 = a -= 5;
            int a3 = a *= 2;
            float a4 = (float)a/ 9;
            float a5 = (float)a % 5;
            int b;
            Console.WriteLine("nhap b:");
            b=int.Parse(Console.ReadLine());

            Console.WriteLine("gia tri a1:" + a1);
            Console.WriteLine("gia tri a2:" + a2);
            Console.WriteLine("gia tri a3:" + a3);
            Console.WriteLine("gia tri a4:" + a4);
            Console.WriteLine("gia tri a5:" + a5);
            Console.ReadLine();
        }
    }
}
