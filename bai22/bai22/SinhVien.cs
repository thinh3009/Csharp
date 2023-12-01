using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace bai22
{
    public class SinhVien
    {
        #region bien lop
        //khai bao bien lop
        private int maSV;
        private string tenSV;
        private float diemThiDH;
        #endregion
        #region constructor
        //khai bao constructor
        //gan gia tri mac dinh cho doi tuong
        public SinhVien()
        {
            this.maSV = 0;
            this.tenSV = "no name";
            this.diemThiDH = 0;
        }
        #endregion
        #region khai bao
        //khai bao constructor
        //gan gia tri do nguoi dung truyen vao
        public SinhVien(int maSV, string tenSV,float diemThiDH)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
            this.diemThiDH=diemThiDH;
        }
        public SinhVien(int maSV, string tenSV, int diemThiDH)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
            this.diemThiDH = diemThiDH;
        }
        //khai bao properties de co the truy xuat sua doi duw lieu
        public string TenSV
        {
            get { return tenSV; }//get gia tri de doc
            set { tenSV = value; }//set dung de thay doi gia tri

        }
        public int MaSV
        {
            set { maSV = value; }
            get { return maSV; }


        }
        public float DiemThiDH
        {
            set { diemThiDH = value; }
            get { return diemThiDH; }


        }
        #endregion
        #region cac phuong thuc
        //phuong thuc to string
        

        //suport method
        //kiem tra dieu kien nhap sinh vien moi
        private bool checkDiemThi()
        {
            return (this.DiemThiDH - 21 >= 0);
        }

        //xuat thong tin
        public void Xuat()
        {
            if(checkDiemThi()==false)
            {
                Console.WriteLine("diem thi thap hon 21");
            }
            else
            {
                Console.WriteLine(ToString());
            }
        }
        //overidng method: 
        //tong
        public int TongDiem(int x,int y)
        {
            return x + y;

        }
        public int TongDiem(int x, int y,int z)
        {
            return x + y -z;

        }
        //parameter list method
        //tinh tong diem trung binh ket thuc hoc ki
        public float TBketthucHK(params float[] mang)
        {
            float s = 0;
            foreach(float f in mang)
            {
                s += f;
            }
            Console.WriteLine("diem trung binh");
            return (s/mang.Count());
        }
        #endregion
    }
}
