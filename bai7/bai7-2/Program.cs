using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float chieucao, cannang,bmi;
            Console.WriteLine("nhap chieu cao: ");
            chieucao=float.Parse(Console.ReadLine());
            Console.WriteLine("nhap can nang: ");
            cannang=float.Parse(Console.ReadLine());
            bmi = cannang / (chieucao * chieucao);
            if (bmi < 15)
            {
                Console.WriteLine("than hinh qua gay");
            }
            else if(bmi>=15 && bmi < 16)
            {
                Console.WriteLine("than hinh gay");
            }
            else if(bmi>=16 && bmi<18.5){
                Console.WriteLine("than hinh hoi gay");
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                Console.WriteLine("than hinh binh thuong");
            }
            else if (bmi >= 25 && bmi < 30)
            {
                Console.WriteLine("than hinh hoi beo");
            }
            else if (bmi >= 30 && bmi < 35)
            {
                Console.WriteLine("than hinh beo");
            }
            else
            {
                Console.WriteLine("than hinh qua beo");
            }
            Console.ReadLine();
        }
    }
}
