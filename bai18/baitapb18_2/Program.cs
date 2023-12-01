using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapb18_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("nhap so phan tu");
            int n = int.Parse(Console.ReadLine());
            //tao list
            List<int> arr = new List<int>(n);
            
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("nhap phan tu thu {0}",i+1);
                //tao bien moi de luu phan tu
                //cach2: ds.Add(int.Parse(Console.ReadLine()))
                int so= int.Parse(Console.ReadLine());
                arr.Add(so*so);
               
            }
            //foreach ds
            foreach (int j in arr)
            {
                Console.Write(j+"\t");
               
                
            }
            int dem = 0;
            foreach(int i in arr)
            {
                if (i > 50)
                {
                    dem++;
                }
            }
            Console.WriteLine("\n"+"co {0} phan tu lon hon 50", dem);
            
            Console.ReadLine();
        }
    }
}
