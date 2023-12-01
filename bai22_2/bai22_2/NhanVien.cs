using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai22_2
{
    public class NhanVien
    {
        //khoi tao
        public int MaNV { get; set; }
        public string TenNV { get; set; }
        
        //phuong thuc
        public double TinhLuong()
        {
            return 1000;
        }
        //ham ao virtual (ghi de overiding)
        public virtual double ThuongCong(int ngayCong)
        {
            if(ngayCong >= 26)
            {
                return 100;
            }
            else
            {
                return 0;
            }
        }
    }
}
