using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class NganHang
    {
        //khai bao constructor
        private string tenNganHang;
        private string soTK;
        public NganHang(string tenNganHang, string soTK)
        {
            this.tenNganHang = tenNganHang;
            this.soTK = soTK;

        }
        //khai bao properties 
        public string TenNganHang//viet hoa chu dau de phan biet
        {
            get { return tenNganHang; }
            set { tenNganHang = value; }
        }
        public string SoTK
        {
            get { return soTK; }
            set { soTK = value; }

        }
        
        //method

        public void NhapNganHang(string tenNganHang, string soTK)
        {

            TenNganHang = tenNganHang;
            SoTK = soTK;
        }
        public void XuatNganHang()
        {
            Console.WriteLine("ten ngan hang: " + tenNganHang);
            Console.WriteLine("so tk: " + soTK);
        }
        public void SuaNganHang()
        {
            Console.WriteLine("ban co muon doi ten ngan hang khong C/K: ");
            char co = Console.ReadKey().KeyChar;

            if (co == 'c' || co == 'C')
            {
                Console.ReadLine();
                Console.Write("nhap ten ngan hang moi: ");
                tenNganHang = Console.ReadLine();
                Console.Write("nhap stk: ");
                soTK = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("ten ngan hang hien tai:");
                XuatNganHang();
            }

        }
    }
}
