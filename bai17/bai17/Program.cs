using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khoi tao mang
            int[,] arr = new int[3, 5];//tao mang 3 hang 5 cot
            //khoi tao va gan gia tri cho mang
            int[,] arr2 = { { 1,2,3}, {6,4,3 } };
            Random rand=new Random();
            int dong = 3;
            int cot = 4;
            int[,] arr3 = new int[dong, cot];
            for(int i = 0; i < dong; i++)
            {
                for(int j = 0; j < cot; j++)
                {
                    //Console.Write(i);
                    //Console.Write(j+"\t");
                    arr3[i, j] = rand.Next(41);
                }
                Console.WriteLine();
            }
            Console.WriteLine(arr3[0,0]);
            Console.WriteLine(arr3[0,1]);
            //xuat mang bat ky
            //getlenght(0): get so dong
            //getlenght(1): get so cot
            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                for(int j = 0;j < arr3.GetLength(1); j++)
                {
                    Console.Write(arr3[i,j]+"\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
