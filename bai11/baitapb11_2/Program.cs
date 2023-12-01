using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapb11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int a;
            int tong = 0;
            Console.WriteLine("nhap a:");
            a=int.Parse(Console.ReadLine());
            while(true)
            {
                if (a % 2 == 0)
                {

                    for (int i = 0; i <= a; i++)
                    {
                        tong = tong + i;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("khong phai so chan vui long nhap lai!!");
                }
                
            }
            Console.WriteLine("tong cac so tu 0 den {0} la {1}", a, tong);
            Console.ReadKey();*/

            int a;
            Console.WriteLine("mời nhập vào số nguyên n: ");
            a = int.Parse(Console.ReadLine());
            int sum = 0;
            if (a % 2 == 0)
            {
                for (int i = 2; i <= a; i++)
                {
                    if (i % 2 == 0)
                    {
                        sum += i;
                    }
                }
                Console.WriteLine("Tổng Số Chẵn là: {0} ", sum);
            }
            else
            {
                Console.WriteLine("tôi 0 tính tổng số lẻ, bye bye");
            }
            Console.ReadLine();

        }
        
    }
}
