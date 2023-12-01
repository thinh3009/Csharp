using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khai bao mang
            int[] stt;
            char[] ch;
            string[] ten;
            //khoi tao mang
            stt = new int[5];
            foreach (int i in stt)
            {
                Console.Write(i+"\t");
            }
            Console.WriteLine("stt2: ");
            int[] stt2 = new int[7];
            foreach (int j in stt2)
            {
                Console.Write(j+"\t");
            }


            //khoi tao va gan gia tri
            int[] mang2 = new int[5] { 1, 2, 4, 5, 5 };
            Console.WriteLine();
            foreach (int j in mang2)
            {
                Console.Write(j + "\t");
            }
            //khoi tao mang ngau nhien

            Random r=new Random();//khai bao ham random
            int[] mang3 = new int[2] {r.Next(50), r.Next(61) };
            //viet gon:int[] mang3 = {r.Next(50), r.Next(61) };
            Console.WriteLine();
            foreach (int j in mang3)
            {
                Console.Write(j + "\t");
            }
            //length:kiem tra do dai
            
            int dai = mang3.Length;
            Console.WriteLine("\n"+dai);

            //truy xuat index
            int[] mang4 = { 1, 3, 4 };
            Console.WriteLine("\n"+mang4[0]);
            Console.WriteLine("\n" + mang4[1]);
            Console.WriteLine("\n" + mang4[mang4.Length-1]);
            //thay doi gia tri trong mang
            int[] mang5 = { 4, 3, 2, 3, 4, 3 };
            mang5[1] = 56;
            foreach (int j in mang5)
            {
                Console.Write(j + "\t");
            }
            //duyet mang dung for dung index

            int[] mang6 = { 1, 2, 5, 3, 2, 5, 6 };
            for (int i = 0; i < mang6.Length; i++)
            {
                Console.WriteLine("\n"+mang6[i]);
            }
            //gan mang
            int[] mang8 = { 1, 2, 3, 4, 5, 6 };
            int[] mang9 = mang8;
            mang8[0] = 100;
            Console.WriteLine("\n" + mang8[0]);
            Console.WriteLine("\n" + mang9[0]);

            //copyto
            int[] mang10 = { 100, 200, 300, 400 };
            int[] mang11 = { 1, 2, 3, 45 ,3,4,5,6,4};
            mang10.CopyTo(mang11, 2);
            Console.WriteLine("mang11: ");
            foreach (int j in mang11)
            {
                Console.Write(j + "\t");
            }
            //copy
            int[] mang12 = { 1, 2, 3, 4, 5, 6 };
            int[] mang13 = new int[4];
            Array.Copy(mang12, mang13, 4);
            Console.WriteLine("\n"+"mang 13: ");
            foreach (int j in mang13)
            {
                Console.Write(j + "\t");
            }

            //clone
            int[] mang14 = { 3, 4, 3, 6, 7, 8, 6 };
            int[] mang15 = (int[])mang14.Clone();
            Console.WriteLine("\n" + "mang 15: ");
            foreach (int j in mang15)
            {
                Console.Write(j + "\t");
            }

            //reverse:dao nguoc mang
            int[] mang16 = { 1, 3, 4, 5, 6, 7, 8, 9 };
            Array.Reverse(mang16);
            Console.WriteLine("\n" + "mang 16: ");
            foreach (int j in mang16)
            {
                Console.Write(j + "\t");
            }
            //sort: sap sep tang dan
            int[] mang17 = { 10, 2, 3, 4, 5, 3, 2, 8, 554, 23 };
            Array.Sort(mang17);
            Console.WriteLine("\n" + "mang 17: ");
            foreach (int j in mang17)
            {
                Console.Write(j + "\t");
            }
            Console.ReadLine();

        }
    }
}
