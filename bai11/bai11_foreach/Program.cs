using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai11_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int thang;
            Console.WriteLine("thang: ");
            thang=int.Parse(Console.ReadLine());
            int[] list = { 1, 3, 5, 7, 8,10,12 };
            foreach (int i in list)
            {
                if (thang == i)
                {
                    Console.WriteLine("thang {0} co 31 ngay",i);
                    break;
                }
                
            }
            Console.ReadLine();
        }
    }
}
