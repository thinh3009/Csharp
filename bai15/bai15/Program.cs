using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string chuoi = "ok numbet one";
            Console.WriteLine(chuoi);
            
            //khai bao nguyen van @
            string chuoi2 = @"D:\asdfasdf";
            Console.WriteLine(chuoi2);
            string chuoi3 = "asdfasdsadf asdfsadf we:\"abc\" ";
            Console.WriteLine(chuoi3);
            string chuoi4 = "asdfasdsadf asdfsadf we:\n \"abc\" ";
            Console.WriteLine(chuoi4);

            //chuyen doi sang chuoi
            int i = 12123;
            Console.WriteLine(i);
            Console.WriteLine(i.GetType().ToString());
            string chuoi5=i.ToString();//cach 1
            string chuoi6 = i + "";//cach 2
            string chuoi7=Convert.ToString(i);//cach 3
            Console.WriteLine(chuoi5);
            Console.WriteLine(chuoi6);
            Console.WriteLine(chuoi7);
            Console.WriteLine(chuoi5.GetType().ToString());
            //tach chuoi ra thanh cac ki tu le
            string chuoi8 = "okehello";
            char[]lst=chuoi8.ToCharArray();
            Console.WriteLine(lst);
            Console.WriteLine(lst.GetType().ToString());
            //length: tra ve do dai chuoi ki tu bao gom space
            string chuoi9 = "tsd asdf";
            int j = chuoi9.Length;
            Console.WriteLine(j);
            Console.WriteLine("ky tu thu 2 cua chuoi: " + chuoi9[j-2]);
            //so sanh chuoi
            string chuoi10 = "123456a";
            string chuoi11 = "123456o";
            int sosanh = chuoi10.CompareTo(chuoi11);
            Console.WriteLine(sosanh);

            //kiem tra chuoi con
            string chuoi12 = "abc";//ktra abc co chua trong chuoi13 khong
            string chuoi13 = "asdfasfesaefabca32t";
            bool l = chuoi13.Contains(chuoi12);
            Console.WriteLine(l);

            //ham copy to
            string chuoi14 = "123456";
            char[] lst2 = new char[6];
            lst2[0] ='a';
            lst2[1] = 'b';
            Console.WriteLine(lst2);
            chuoi14.CopyTo(1, lst2, 2, 4);//chuoi14.CopyTo(index_chuoi14, lst2, index_lst2, 4 ki tu)
            chuoi14.CopyTo(1, lst2, 1, 4);
            Console.WriteLine(lst2);

            //ham bool endwidth
            string chuoi15 = "nghe.mp3";
            bool kt=chuoi15.EndsWith("3");//kiem tra ket thuc la so 3 khong
            Console.WriteLine(kt);

            //gan chuoi string theo format
            int n = 14;
            string chuoi16 = string.Format("n={0} va can bac 2 cua n la: {1}", n, Math.Sqrt(n));
            Console.WriteLine(chuoi16);
            //bool equals
            string chuoi17 = "haha";
            string chuoi18 = "haha";
            bool kt2 = chuoi17.Equals(chuoi18);
            Console.WriteLine(kt2);
            //chen chuoi
            string chuoi19 = "123";
            string chuoi20 = "haefs";
            chuoi19 = chuoi19.Insert(3, chuoi20);//chuoi19.Insert(index_chuoi19, chuoi20)
            Console.WriteLine(chuoi19);
            //indexof: tim gia tri index
            string chuoi21 = "23aasdfasfe";
            int kq4=chuoi21.IndexOf("a");
            Console.WriteLine(kq4);
            Console.WriteLine(chuoi21.Length);

            //lastIndex:kiem tra index cuoi cung
            string chuoi22 = "23aasdfasfe";
            int kq5 = chuoi22.LastIndexOf('a');
            Console.WriteLine(kq5);

            //remove
            string chuoi23 = "123456";
            chuoi23 = chuoi23.Remove(1, 2);
            Console.WriteLine(chuoi23);
            Console.ReadLine();
            

        }
    }
}
