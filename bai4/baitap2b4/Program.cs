using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap2b4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const float pi= 3.14f;
            float r;
            Console.Write("nhap ban kinh: ");
            r=float.Parse(Console.ReadLine());
            float chuvi = 2 * r * pi;
            float dientich = pi * (r * r);
            Console.WriteLine("chu vi: " + chuvi);
            Console.WriteLine("dien tich: " + dientich);
            Console.ReadLine();
        }
    }
}
