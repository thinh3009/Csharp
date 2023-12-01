using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "2+5+7=","5*10=","sqrt(16)=","12%2=","5//2="};
            List<int> lst2 = new List<int>() { 14,50,4,0,4};
            for(int i=0;i<list.Count;i++)
            {
                Console.WriteLine(list[i]);
                Console.WriteLine();
                int ans=int.Parse(Console.ReadLine());
                if (ans == lst2[i])
                {
                    Console.WriteLine("correct");
                }
                else {
                    Console.WriteLine("wrong, ansser: " + lst2[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
