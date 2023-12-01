using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = @"toi cham hoc 
                         toi chiu kho 
                         toi dep zai";//khai bao doan van bang @
            
            string[] lst = a.Split(' ');
            int dem = 0;
            foreach (string i in lst){

                //Console.WriteLine(i);
                if ("toi".Equals(i))
                {
                    dem++;
                }
            }
            Console.WriteLine(dem);
            Console.ReadKey();
            
        }
    }
}
