using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x, y;
            x = 5;
            y = 5;
            Console.WriteLine("x="+x);
            y += x;
            
            Console.WriteLine("y=" + y);
            Console.ReadKey();
        }
    }
}
