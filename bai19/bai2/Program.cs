using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>() 
            { 
                { "A", 1 }, { "B", 2 }, { "C", 3 }, { "D", 2 }, { "E", 1 }, 
                { "F", 4 }, { "G", 2 }, { "H", 4 }, { "I", 1 }, { "J", 8 }, 
                { "K", 5 }, { "L", 1 }, { "M", 3 }, { "N", 1 }, { "O", 1 }, 
                { "P", 3 }, { "Q", 10 }, { "R", 1 }, { "S", 1 }, { "T", 1 }, 
                { "U", 1 }, { "V", 4 }, { "W", 4 }, { "X", 8 }, { "Y", 4 }, { "Z", 10 } 
            };
            int tong = 0;
            foreach (KeyValuePair<string, int> kvp in dic)
            {
                Console.WriteLine(kvp.Key+"\t"+kvp.Value);
                
                tong += kvp.Value;

            }
            Console.WriteLine("tong cac so: "+ tong);
            //chuyển đổi chuỗi : "University of Technology and Education" sang số
            /*string str = "University of Technology and Education";
            string str2 = "";
            foreach (char c in str)
            {
                str2+=char.ToUpper(c);
            }
            Console.WriteLine(str2);
            //chuyen sang so
            string so = " ";
            foreach(char c in str2)
            {
                if (c==' ')//kiem tra co cach khong
                {
                    so += c;
                }
                else
                {
                    so += dic[c.ToString()];//ep kieu
                }
            }
            Console.WriteLine(so);
            Console.ReadKey();*/
            string str = "University of Technology and Education";
            string str2 = "";
            foreach (char c in str)
            {
                str2 += char.ToUpper(c);
            }
            Console.WriteLine(str2);
            //chuyen sang so
            string so = "";
            foreach (char c in str2)
            {
                if (c == ' ')//kiem tra co cach khong
                {
                    so += c;
                }
                else
                {
                    so += dic[c.ToString()];//ep kieu
                }
            }
            Console.WriteLine(so);
            Console.ReadKey();
        }
    }
}
        