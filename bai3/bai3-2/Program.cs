using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x, y;
            Console.WriteLine("nhap x: ");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("nhap y:");
            y = float.Parse(Console.ReadLine());

            float x1 = x + y;
            float x2 = x - y;
            float x3 = x * y;
            float x4 = x / y;
            float x5 = x % y;
            Console.WriteLine("{0}+{1}={2}",x,y,x1);
            Console.WriteLine("{0}+{1}={2}", x, y, x2);
            Console.WriteLine("{0}+{1}={2}", x, y, x3);
            Console.WriteLine("{0}+{1}={2}", x, y, x4);
            Console.WriteLine("{0}+{1}={2}", x, y, x5);
            Console.ReadLine();        }
    }
}
