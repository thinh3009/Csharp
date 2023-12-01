using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("nhap bien a: ");
            a=int.Parse(Console.ReadLine());
            int div = a % 2;
            //switch case
            switch (div)
            {
                case 0:
                    Console.WriteLine("{0} la so chan",a);
                    break;
                default: 
                    Console.WriteLine("{0} la so le");
                    break;
            }    
            Console.ReadLine();
        }
    }
}
