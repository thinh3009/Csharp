using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    
    public class CongTy:NganHang
    {
        //khai bao constructor
        private string tenCty { get;set; }
        private string diaChi { get; set; }
        private string maSoThue { get; set; }
        private string hinhThucThanhToan { get; set; }
        private string webSite { get; set; }

        
        //methods
        public void NhapCongTy(string tenCty, string diaChi, string maSoThue, string hinhThucThanhToan, string webSite)
        {
            Console.WriteLine("nhap ten cong ty");   
            tenCty=Console.ReadLine();
            Console.WriteLine("nhap dai chi");
            diaChi =Console.ReadLine();
            Console.WriteLine("nhap ma so thue");
            maSoThue =Console.ReadLine();
            Console.WriteLine("nhap hinh thuc thanh toan");
            hinhThucThanhToan =Console.ReadLine();
            Console.WriteLine("nhap website");
            webSite =Console.ReadLine();

        }
        public void XuatCongty()
        {
            Console.WriteLine("ten cong ty: " + tenCty);
            Console.WriteLine("dia chi: " + diaChi);
            Console.WriteLine("ma so thue: " + maSoThue);
            Console.WriteLine("hinh thuc thanh toan: " + hinhThucThanhToan);
            Console.WriteLine("web site: " + webSite);

        }


    }
}
