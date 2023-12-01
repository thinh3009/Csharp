using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai22_2
{
    public class NhanVienDiCa:NhanVien
    {
        //khai bao them thuoc tinh
        public string Ca { get; set; }
        //phuong thuc tinh luong nhan vien di ca
        public new double TinhLuong()
        {
            return base.TinhLuong()*1.05;
        }
    }
}
