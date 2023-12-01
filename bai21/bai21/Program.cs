using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai21
{
    internal class Program
    {
        static void ngoaile()
        {
            try
            {
                Console.WriteLine("nhap ngay thang nam sinh: ");
                string s = Console.ReadLine();
                DateTime birth = DateTime.Parse(s);
                Console.WriteLine("ban sinh ngay: " + birth.ToString("MM/dd/yyyy"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }
            finally
            {
                Console.WriteLine("thanks");
            }
            
        }
        static void ngoaile2()
        {
            Console.WriteLine("moi nhap vao tu so");
            int tu=int.Parse(Console.ReadLine());
            Console.WriteLine("moi nhap mau so");
            int mau=int.Parse(Console.ReadLine());
            if (mau == 0)
            {
                throw new ArithmeticException("loi mau bang 0");
            }

        }
        static void Main(string[] args)
        {
            //ngoaile();
            try
            {
                ngoaile2();
            }
            catch(ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
