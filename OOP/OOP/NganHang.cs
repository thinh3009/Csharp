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
        
        private string tenNganHang {  get; set; }
        private string soTK {  get; set; }
        
        
        
      
        
        //method

        public void NhapNganHang()
        {
            Console.WriteLine("nhap ten ngan hang");
            tenNganHang = Console.ReadLine();
            Console.WriteLine("nhap so tai khoan");
            soTK = Console.ReadLine();
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
