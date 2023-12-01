using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hoten;
            float diemtoan;
            float diemvan;

            Console.WriteLine("moi nhap vao ho ten: ");
            hoten = Console.ReadLine();

            Console.WriteLine("moi nhap vao diem toan: ");
            diemtoan=float.Parse(Console.ReadLine());

            Console.WriteLine("moi nhap vao diem van: ");
            diemvan = float.Parse(Console.ReadLine());

            Console.WriteLine("hoc sinh {0} co diem toan la {1},diem van{2}", hoten, diemtoan, diemvan);
            
            Console.ReadKey();
        }
    }
}
