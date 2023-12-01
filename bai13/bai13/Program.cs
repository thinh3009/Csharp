using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //random
            Random rand = new Random();
            //random so nguyen
            int so=rand.Next(50,101);//50->100
            Console.WriteLine("so ngau nhien may sinh ra: " + so);
            //lay so ngau nhien tu 0 den 1
            double so2 = rand.NextDouble();
            Console.WriteLine("so ngau nhien: " + so2);
            //lay so 1.344534
            double so3 = so2 + so;
            Console.WriteLine("gia tri ngay nhien: " + so3);
            //cach2
            double so4 = so2 * 10;
            Console.WriteLine("gia tri ngau nhien 2 mong muon: "+so4);
            Console.ReadKey();
        }
    }
}
