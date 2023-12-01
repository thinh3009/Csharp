using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int thang;
            Console.WriteLine("nhap thang bat ki: ");
            thang=int.Parse(Console.ReadLine());
            if (thang==1 || thang == 3 || thang == 5 || thang == 7 || thang == 8 || thang == 10 || thang == 12)
            {
                Console.WriteLine("thang {0} co 31 ngay", thang);
            }
            else if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
            {
                Console.WriteLine("thang {0} co 30 ngay",thang);
            }
            else if (thang == 2)
            {
                float nam;
                Console.WriteLine("nhap nam: ");
                nam = float.Parse(Console.ReadLine());
                if ((nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0)
                {
                    Console.WriteLine("nam {0} co 29 ngay", nam);
                }
                else
                {
                    Console.WriteLine("nam {0} co 28 ngay", nam);
                }
            }
            Console.ReadLine();
        }
    }
}
