using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so phan tu");
            int n= int.Parse(Console.ReadLine());
            List<int> list = new List<int>(n);
            for(int i=0;i<n; i++)
            {
                
                Console.WriteLine("nhap phan tu thu {0}: ", i+1);
                int phantu = int.Parse(Console.ReadLine());
                list.Add(phantu);
            }
           
            List<int> positions = new List<int>();
            int dem = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < 5)
                {
                    dem++;
                    positions.Add(i);
                }
                
            }
            Console.WriteLine("Danh sách các phần tử nhỏ hơn 5:");

            foreach (int i in positions)
            {
                Console.WriteLine("phan tu tai vi tri thu {0} co gia tri {1}", i + 1, list[i]);
            }
            Console.ReadLine();
            
        }
    }
}
