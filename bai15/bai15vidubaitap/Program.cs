using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai15vidubaitap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int demso = 0, demchu = 0, deminhoa = 0,demspace=0;
            string chuoi = "hello welcome to c#";
            char[] lst=chuoi.ToCharArray();
            foreach (char c in lst)
            {
                //Console.WriteLine(c);
                if (char.IsDigit(c))
                {
                    demso++;
                }
                else if (char.IsLower(c))
                {
                    demchu++;
                }
                else if (char.IsUpper(c))
                {
                    deminhoa++;
                }
                else if (char.IsWhiteSpace(c))
                {
                    demspace++;
                }
                
            }
            Console.WriteLine("chuoi co ky tu thuong: " + demchu);
            Console.WriteLine("chuoi co ky tu so: " + demso);
            Console.WriteLine("chuoi co ky tu inhoa: " + deminhoa);
            Console.WriteLine("chuoi co ky tu khoang rtang: " + demspace);
            Console.ReadLine();
        }
    }
}
