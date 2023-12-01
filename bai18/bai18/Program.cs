using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khoi tao list
            List<string> list = new List<string>();//ds cac phan tu la string
            List<int> ds2= new List<int>();//ds ptu la so nguyen
            //khoi tao danh sach co san mot so phan tu 
            List<int> ds3= new List<int>() { 1,2,3,4,5,5};
            foreach(int i in ds3)
            {
                Console.Write(i);
            }
            Console.WriteLine();

            //phuong thuc add: them ptu vao cuoi
            List<int> ds4 = new List<int>() { 1, 2, 3, 4 };
            ds4.Add(134);
            Console.WriteLine("ds4:");
            foreach (int i in ds4)
            {
                Console.Write(i+"\t");
            }
            Console.WriteLine();
            //remove
            List<int> ds5 = new List<int>() { 6, 8, 5, 4, 2, 32 };
            ds5.Remove(6);
            foreach (int i in ds5)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();

            //count
            List<int> ds6 = new List<int>() { 6, 8, 5, 4, 2, 32 };
            Console.WriteLine(ds6.Count);
            //clear
            List<int> ds7 = new List<int>() { 6, 8, 5, 4, 2, 32 };
            ds7.Clear();
            //addrange:them toan bo danh sach cu vao danh sach moi
            List<int> ds8 = new List<int>() { 4, 2, 32 };
            List<int> ds9 = new List<int>() { 200, 334 };
            ds8.AddRange(ds9);
            foreach (int i in ds8)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            //bool<ds>.contains(<value>)
            List<int> ds10 = new List<int>() { 200, 334 };
            bool kq = ds10.Contains(200);
            Console.WriteLine(kq);
            //getrange
            List<int> ds11 = new List<int>() { 200, 334,34,23 };
            List<int> ds12 = ds11.GetRange(1, 3);//lay tu vi tri index va lay so phan tu mong muon
            foreach (int i in ds12)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            List<int> ds13 = new List<int>() { 200, 334,4,5,2,3 };
            int check=ds13.IndexOf(0);
            Console.WriteLine(check);

            //insert
            List<int> ds14 = new List<int>() { 200, 334, 4, 5, 2, 3 };
            ds14.Insert(1, 70);
            foreach (int i in ds14)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            //insertRange:chen vao trong dsach moi
            List<int> ds15 = new List<int>() { 5, 2, 3 };
            List<int> ds16 = new List<int>() { 200, 334, 4, 5, 2, 3 };
            ds15.InsertRange(2, ds16);
            foreach (int i in ds15)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            //removeat:xoa phan tu tai vi tri index
            List<int> ds17 = new List<int>() { 200, 334, 4, 5, 2, 3 };
            ds17.RemoveAt(1);
            foreach (int i in ds17)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            //removerange:xoa tu index va xoa nhieu ptu
            List<int> ds18 = new List<int>() { 200, 334, 4, 5, 2, 3 };
            ds18.RemoveRange(1, 3);
            foreach (int i in ds18)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            //reverse
            List<int> ds19 = new List<int>() { 200, 334, 4, 5, 2, 3 };
            ds19.Reverse();
            foreach (int i in ds19)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            //sort
            List<int> ds20 = new List<int>() { 200, 334, 4, 5, 2, 3 };
            ds20.Sort();
            foreach (int i in ds20)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            //binarysearch:tim nhi phan vi tri index(phai sap xep moi tim dc)
            int kq2 = ds20.BinarySearch(200);
            Console.WriteLine(kq2);
            //max,min
            int kq3 = ds20.Max();
            Console.WriteLine("max: "+kq3);
            Console.ReadLine();
        }
    }
}
