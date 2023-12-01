using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapb11_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("nhap a: ");
            
            a = int.Parse(Console.ReadLine());
            while (a <= 1)
            {
                Console.WriteLine("a phai lon hon 1");
                a = int.Parse(Console.ReadLine());
            }
                
                if (a % 1 == 0 && a % a == 0 && a % 2 != 0)
                {
                    Console.WriteLine("so {0} la so nguyen to", a);
                }
                else
                {
                    Console.WriteLine("so {0} khong la so nguyen to", a);
                }

            
            Console.ReadKey();
        }
    }
}





/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapb11_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("nhap a: ");

            a = int.Parse(Console.ReadLine());
            while (a <= 1)
            {
                Console.WriteLine("a phai lon hon 1");
                a = int.Parse(Console.ReadLine());
            }

            bool isPrime = true;
            for (int i = 2; i * i <= a; i++)
            {
                if (a % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine("so {0} la so nguyen to", a);
            }
            else
            {
                Console.WriteLine("so {0} khong la so nguyen to", a);
            }

            Console.ReadKey();
        }
    }
}
*/
