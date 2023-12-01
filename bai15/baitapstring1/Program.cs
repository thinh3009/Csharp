using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace baitapstring1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("nhap chuoi");
            string n = Console.ReadLine();
            int dem = 0;
            foreach(char i in n)
            {
                dem++;
            }
            Console.WriteLine("ki tu {0} ban nhap vao la {1}", n, dem);
            Console.ReadLine();
        }
    }
}
