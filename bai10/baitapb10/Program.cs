using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapb10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=0;
            Console.WriteLine("nhap n:");
            n=int.Parse(Console.ReadLine());
            while (n<1||n>99)
            {
                Console.WriteLine("n chi dc 1==>99");
                n=int.Parse(Console.ReadLine());
            }
      
            Console.ReadKey();
        }

    }
}
