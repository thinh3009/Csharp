/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap chuoi");
            string nhap = Console.ReadLine();
            string chuoiso = "";
            string chuoikytu = "";
            foreach (char i in nhap)
            {
                if (char.IsDigit(i))
                {
                    chuoiso += i;
                }
                else
                {
                    chuoikytu += i;
                }
                Console.WriteLine(chuoiso);
                Console.WriteLine(chuoikytu);
                Console.ReadKey();
            }

        }
    }
}*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap chuoi");
            string nhap = Console.ReadLine();
            string chuoiso = "";
            string chuoikytu = "";
            foreach (char i in nhap)
            {
                if (char.IsDigit(i))
                {
                    chuoiso += i;
                }
                else
                {
                    chuoikytu += i;
                }
            }
            Console.WriteLine(chuoiso);
            Console.WriteLine(chuoikytu);
            Console.ReadKey();
        }
    }
}