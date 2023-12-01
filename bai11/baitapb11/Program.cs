using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapb11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int tong = 1;
            Console.WriteLine("nhap n: ");
            n=int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                
                
                tong = tong * i;
                
            }
            Console.WriteLine("{0}!={1}", n, tong);

            Console.ReadLine();
        }
    }
}
