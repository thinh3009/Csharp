using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai20
{
    internal class Program
    {
        /// <summary>
        /// ham nay tinh tong
        /// </summary>
        /// <param name="x">nhap x</param>
        /// <param name="y">nhap y</param>
        /// <param name="z">nhap z</param>
        /// <returns>return tong 3 so</returns>
        static int tong(int x, int y, int z)
        {
            return x + y + z;
        }
        //giat thua
        static int giaithua(int n)
        {
            int giai = 1;
            for (int i=1; i <= n; i++)
            {
                giai *= i;
            }
            return giai;
        }
        //vidu static void
        static void xinchao(string m)
        {
            if (m == "nam")
            {
                Console.WriteLine("hi cau");
            }
            if (m == "nu")
            {
                Console.WriteLine("chao cau");
            }
        }
        //truyen tham tri: khong thay doi sau khi goi ham
        static void thamtri(int a)
        {
            a = a + 1;
            Console.WriteLine("gia tri a: "+a);
        }
        //ref: truyen tham chieu-->co the thay doi gia tri cua bien sau khi goi ham
        static void thamchieuRef(ref int b)
        {
            b++;
            Console.WriteLine("b la: " + b);
        }
        //out: truyen tham chieu cach2
        //phai gian gia tri cho bien truoc khi thoat khoi ham
        static void thamchieuOut(out int c)
        {
            c = 5;
            Console.WriteLine("gia tri c: " + c);
        }
        static void Main(string[] args)
        {
            int kq = tong(2, 3, 4);
            Console.WriteLine(kq);
            //xuat giai thua
            int k = 3;
            int kq2=giaithua(k);
            Console.WriteLine(kq2);

            xinchao("nam");
            int kq3 = tong(2, 3, 1);

            //truyen tham tri
            int a = 1;
            Console.WriteLine("a truoc goi ham: "+a);
            thamtri(a);
            Console.WriteLine("a sau goi ham: " + a);

            /*
             truyen tham chieu
             ref phai khoi tao gia tri cho bien truoc khi goi ham
             int b; -->se bao loi
             */
            int b = 2;
            Console.WriteLine("b truoc goi ham: " + b);
            thamchieuRef(ref b);
            Console.WriteLine("b sau goi ham: " + b);
            //out: phai gian gia tri cho bien truoc khi thoat khoi ham
            int c;
            thamchieuOut(out c);
            Console.WriteLine("c sau khi goi: "+c);

            Console.ReadKey();
        }
    }
}
