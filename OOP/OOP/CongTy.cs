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
        private string tenCty;
        private string diaChi;
        private string maSoThue;
        private string hinhThucThanhToan;
        private string webSite;

        

        public CongTy(string tenNganHang, string soTK, string tenCty, string diaChi, string maSoThue, string hinhThucThanhToan, string webSite)
        : base(tenNganHang, soTK)
        {
            this.tenCty = tenCty;
            this.diaChi = diaChi;
            this.maSoThue = maSoThue;
            this.hinhThucThanhToan= hinhThucThanhToan;
            this.webSite = webSite;
        }
        //khai bao properties
        public string TenCty { 
            get {  return tenCty; } 
            set { tenCty = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public string MaSoThue
        {
            get { return maSoThue; }
            set { maSoThue = value; }
        }
        public string HinhThucThanhToan
        {
            get { return hinhThucThanhToan; }
            set { hinhThucThanhToan = value; }
        }
        public string WebSite
        {
            get { return webSite; }
            set { webSite = value; }
        }
        //methods
        public void NhapCongTy(string tenCty, string diaChi, string maSoThue, string hinhThucThanhToan, string webSite)
        {
            
            TenCty=tenCty;
            DiaChi=diaChi;
            MaSoThue=maSoThue;
            HinhThucThanhToan=hinhThucThanhToan;
            WebSite=webSite;

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
