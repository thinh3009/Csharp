using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai16baitap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số lượng phần tử của mảng: ");
            int n = int.Parse(Console.ReadLine());

            int[] mang = new int[n];
            Random randNum = new Random();
            for (int i = 0; i < mang.Length; i++)
            {
                mang[i] = randNum.Next(50);
                Console.WriteLine("Phần tử thứ {0} của mảng là: {1}", i, mang[i]);
            }
            Array.Reverse(mang);
            foreach (int j in mang)
            {
                Console.Write(j + "\t");
            }
            Array.Sort(mang);
            Console.WriteLine();
            foreach (int j in mang)
            {
                Console.Write(j + "\t");
            }
            Console.WriteLine() ;
            int tong = 0;
            for(int i=0;i<mang.Length; i++)
            {
                tong += mang[i];
            }
            Console.WriteLine("tong phan tu trong mang: " + tong);
            //tim so trong mang
            Console.WriteLine("nhap so bat ki");
            
            int sobatki = Convert.ToInt32(Console.ReadLine());
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (mang[i]== sobatki)
                {
                    Console.WriteLine("tim thay vi tri thu {0} la {1}", sobatki, i);
                    dem++;
                }
            }
            if (dem == 0)
            {
                Console.WriteLine("khong tim thay!");
            }
            /*bool found = false;//tao bool tim gia tri


            for (int i = 0; i < mang.Length; i++)
            {
                if (mang[i] == sobatki)
                {
                    Console.WriteLine("so ma ban nhap nam tai vi tri thu {0}", i);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("khong co so nao");
            }*/
            Console.ReadLine();

        }
    }
}
