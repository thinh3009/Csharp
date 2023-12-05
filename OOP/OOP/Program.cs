using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            
            
            
            CongTy cty = new CongTy();
            TenHang hang= new TenHang();
            NganHang bank = new NganHang();
            cty.XuatNganHang();
            
            
            

            hang.NhapHang();
            hang.XuatHang();
            double tinh = hang.KtraGiamGia();
            Console.WriteLine(tinh);

            Console.ReadKey();
            
        }
    }
}
