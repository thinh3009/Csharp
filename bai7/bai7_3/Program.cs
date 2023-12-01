using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float namduonglich;
            Console.WriteLine("nhap vao mot nam duong: ");
            namduonglich = float.Parse(Console.ReadLine());

            if ((namduonglich % 4 == 0 && namduonglich  % 100 != 0) || namduonglich % 400 == 0)
            {
                Console.WriteLine("nam {0} la nam nhuan", namduonglich);
            }
            else
            {
                Console.WriteLine("nam {0} la nam khong nhuan",namduonglich);
            }
            Console.ReadLine();
        }
    }
}
