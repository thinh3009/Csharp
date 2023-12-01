using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //toan tu 3 ngoi
            int n;
            Console.WriteLine("nhap vao n: ");
            n=int.Parse(Console.ReadLine());
            string traloi = (n % 2 == 0) ? "chan" : "le";
            Console.WriteLine(traloi);
            Console.ReadLine();
        }
    }
}
