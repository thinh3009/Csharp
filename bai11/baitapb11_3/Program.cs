using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapb11_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,tong=0;
            Console.WriteLine("nhap so: ");
            n=int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                if (i == 3 )
                {
                    continue;
                }
                else if( i % 2 != 0)
                {
                    tong = tong + i;
                }
                
                
            }
            Console.WriteLine("tong cua {0}={1}",n,tong);
            Console.ReadKey();
        }
    }
}
