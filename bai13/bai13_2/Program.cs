using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai13_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime birth = new DateTime(2002, 01, 21);
            Console.WriteLine("ngay thang nam sinh: " + birth.ToString("dd/MM/yyyy"));
            Console.WriteLine("ngay sinh: " + birth.ToString("dd"));
            Console.WriteLine(" thang sinh: " + birth.ToString("MM"));
            Console.WriteLine("nam sinh: " + birth.ToString("yyyy"));
            DateTime birth2 = DateTime.Parse("11/24/2003");
            Console.WriteLine("ngay thang nam sinh: " + birth2.ToString("dd/MM/yyyy"));
            //viet chuong trinh cho ng nhap ngay thang nam sinh
            Console.WriteLine("nhap ngay thang nam sinh: ");
            string s=Console.ReadLine();
            DateTime birthday = DateTime.Parse(s);
            Console.WriteLine("ngay sinh cua ban : " + birthday.ToString("dd"));
            Console.WriteLine("thang sinh cua ban : " + birthday.ToString("MM"));
            Console.WriteLine("nam sinh cua ban : " + birthday.ToString("yyyy"));
            Console.ReadKey();
        }
    }
}
