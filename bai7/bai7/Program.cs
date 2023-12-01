using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float tong;
            float hieu;
            
            Console.WriteLine("nhap tong 2 so: ");
            tong=float.Parse(Console.ReadLine());
            Console.WriteLine("nhap hieu 2 so:");
            hieu=float.Parse(Console.ReadLine());
            float x = (float)(tong + hieu) / 2;
            float y = (float)(tong - hieu) / 2;
            Console.WriteLine("gia tri x can tim: " + x);
            Console.WriteLine("gia tri y can tim: " + y);
            Console.ReadKey();
            
        }
    }
}
