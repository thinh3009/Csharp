using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch1 = 'a';
            Console.WriteLine(ch1);
            Console.WriteLine(ch1.GetType().ToString());
            //cach2
            char ch2 = (char)64;
            Console.WriteLine(ch2);
            Console.WriteLine(ch2.GetType().ToString());
            //ep kieu char cho du lieu nhap vao
            char ch3=char.Parse("b");
            Console.WriteLine(ch3);
            Console.WriteLine(ch3.GetType().ToString());
            //chuyen doi kieu du lieu
            char ch4=Convert.ToChar("t");
            Console.WriteLine(ch4);
            Console.WriteLine(ch4.GetType().ToString());

            //so sanh 2 ki tu
            char ch7 = 'a';
            char ch8 = 'b';
            char ch9 = 'a';
            char ch10 = 'm';
            Console.WriteLine(ch7.CompareTo(ch8));
            Console.WriteLine(ch8.CompareTo(ch7));
            Console.WriteLine(ch7.CompareTo(ch9));
            Console.WriteLine(ch7.CompareTo(ch10));

            //sosanh 2 ky tu
            Console.WriteLine(ch7.Equals(ch8));
            Console.WriteLine(ch7.Equals(ch9));
            //cac phuong thuc 
            Console.WriteLine(char.IsDigit('2'));
            Console.WriteLine(char.IsLetter('r'));
            Console.WriteLine(char.IsWhiteSpace('t'));
            Console.WriteLine(char.IsLower('r'));
            Console.WriteLine(char.IsUpper('A'));
            Console.WriteLine(char.ToUpper('r'));//chuyen ki tu sang in hoa
            Console.WriteLine(char.ToLower('G'));
            Console.ReadKey();

        }
    }
}
