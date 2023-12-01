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
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("nhap so phan tu");
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>(n);
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("nhap phan tu thu {0}: ", i + 1);
                int phantu = int.Parse(Console.ReadLine());
                list.Add(phantu);
            }
            //sap xep list truowc moi dung duoc vong lap
            list.Sort();
            for (int i = 0; i < n; i++)
            {
                if (list.Max() == list[i])
                {
                    Console.WriteLine("phần tử lớn thứ 2 trong list là :" + list[i - 1]);
                    Console.WriteLine("Index số đó là :" + (i - 1));
                }
                if (list.Min() == list[i])
                {
                    Console.WriteLine("phần tử nhỏ thứ 2 trong list là :" + list[i + 1]);
                    Console.WriteLine("Index số đó là :" + (i + 1));
                }
            }
            foreach (int j in list)
            {
                Console.Write(j + "\t");
            }

            Console.ReadLine();
        }
    }
}
