using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapb15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "english = 78 science = 83 math = 68 history = 65";
            string[] lst=str1.Split(' ');
            string strso = "";
            foreach (string str2 in lst)
            {
                Console.WriteLine(str2);
                foreach (char str3 in str2)
                {
                    Console.WriteLine(str3);
                    if (char.IsDigit(str3))
                    {
                        strso += str2 + " ";
                        break;
                    }
                }
            }
            Console.WriteLine(strso);
            strso=strso.Trim();
            Console.WriteLine(strso);
            //tach strso theo dau cach
            int tong = 0;
            string[] lst2 = strso.Split(' ');
            foreach (string i in lst2) { 
                Console.WriteLine("\n"+i);
                tong +=int.Parse(i);//ep kieu tu string sang int
            }
            Console.WriteLine(tong);
            Console.WriteLine(lst2.Length);
            Console.WriteLine("trung binh cong:" + (float)tong / (lst2.Length));


            Console.ReadLine();
            
        }
    }
}
