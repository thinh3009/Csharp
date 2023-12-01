using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            float z = a / b;
            Console.WriteLine( "gia tri cua z la: "+z);
            float z2 = (float)a / b;
            Console.WriteLine("gia tri cua z la: " + z2);
            byte x = 266;
            int y = x;
            
            
            Console.ReadKey();
        }
    }
}
