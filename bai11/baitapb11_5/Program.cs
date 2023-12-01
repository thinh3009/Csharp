using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapb11_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tong = 0,giaithua=1;

            for(int i = 1; i <= 10; i++)
            {
                //nhan gia tri cua tung giai thua
                giaithua = giaithua * i;
                //cong cac giai thua
                tong = tong + giaithua;
            }
            Console.WriteLine("tong 1!+2!+3!+....+10!="+tong);
            Console.ReadKey();
        }
        
    }
}
