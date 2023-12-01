using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai8baitap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float dtb;
            Console.WriteLine("nhap diem trung binh: ");
            dtb= float.Parse(Console.ReadLine());
            string xepLoai = (dtb >= 8) ? "Giỏi" : ((dtb >= 6.5) ? "Khá" : ((dtb >= 5) ? "Trung bình" : "Yếu"));
            Console.WriteLine("diem {0} la {1}", dtb, xepLoai);
            Console.ReadLine();
        }

    }
}
