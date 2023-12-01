using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapb18_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("nhap so phan tu");
            n=int.Parse(Console.ReadLine());
            List<int> arr = new List<int>(n);//ds ptu la so nguyen
            Random r=new Random();
            //lap i den n goi arr de them random 1->100
            for(int i=0;i<n;i++)
            {
                arr.Add(r.Next(1,101));
            }
            Console.WriteLine("danh sach: ");
            //lap de in ra mang da them
            foreach(int j in arr) {
                Console.WriteLine(j);
            }
            Console.ReadKey();

        }
    }
}
