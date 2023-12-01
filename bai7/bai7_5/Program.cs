using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ax^2+bx+c=0
            float a, b, c;
            float denta;
            Console.WriteLine("nhap a,b,c: ");
            a=float.Parse(Console.ReadLine());
            b=float.Parse(Console.ReadLine());
            c=float.Parse(Console.ReadLine());
            denta = (b * b) - 4 * a * c;
            if (denta < 0)
            {
                Console.WriteLine("phuong trinh {0}x^2+{1}x+{2}=0 vo nghiem", a, b, c);
            }
            else if (denta == 0)
            {
                Console.WriteLine("phuong trinh {0}x^2+{1}x+{2}=0 co nghiem kep", a, b, c);
                float x = (float)-b / (2 * a);
                Console.WriteLine("x={0}",x);
            }
            else
            {
                Console.WriteLine("phuong trinh {0}x^2+{1}x+{2}=0 co nghiem phan biet",a,b,c);
                float x1, x2;
                x1 = (float)(-b + Math.Sqrt(denta)) / 2;
                x2= (float)(-b - Math.Sqrt(denta)) / 2;
                Console.WriteLine("x1={0}", x1);
                Console.WriteLine("x2={0}", x2);

            }
            Console.ReadLine();
        }
    }
}
