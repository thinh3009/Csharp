using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapb11_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 10; i <= 50; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("cac so chia het cho 3: " + i);
                }
                
            }
            Console.ReadLine();
        }
    }
}
