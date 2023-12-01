using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapb11_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int tong=0,n;
            Console.WriteLine("nhap n: ");
            n=int.Parse(Console.ReadLine());
            for(int i = 1; i < n; i++)
            {
                if (n%i==0)
                {
                    tong=tong+i;
                }
                
            }
            if (tong == n)
            {
                Console.WriteLine("{0} la so hoan hao", n);

            }
            else
            {
                Console.WriteLine("{0} khong la so hoan hao",n);
            }
            Console.ReadLine();*/
            for(int n=1;n<=1000;n++)
            {
                int tong = 0;
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        tong = tong + i;
                    }

                }
                if (tong == n)
                {
                    Console.WriteLine("{0} la so hoan hao", n);

                }
            }
            Console.ReadLine();
        }
    }
}
