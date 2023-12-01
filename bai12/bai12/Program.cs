using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pi=" + Math.PI);
            int a = 4;
            int b = 20;
            Console.WriteLine("sqrl: " + Math.Sqrt(a));
            Console.WriteLine("2 mu 3: " + Math.Pow(2, 3));
            //min
            Console.WriteLine("min: " + Math.Min(a, b));
            //mmax
            Console.WriteLine("min: " + Math.Max(a, b));
            //round
            float c = 2.34534534534f;
            Console.WriteLine("so c sau khi lam tron: " + Math.Round(c, 3));
            //sin
            Console.WriteLine(" sin 188= " + Math.Sin(30*Math.PI/180));
            Console.ReadKey();
        }
        
    }
}
