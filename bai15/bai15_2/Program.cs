using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai15_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //replace
            string chuoi24 = "123345456356";
            chuoi24 = chuoi24.Replace("3", "he");
            Console.WriteLine(chuoi24);
            //bool startwith
            string chuoi25 = "toilathinh";
            bool kt6 = chuoi25.StartsWith("toila");
            Console.WriteLine(kt6);
            //substring(trich loc chuoi con tu chuoi ban dau)
            string chuoi26 = "1233456";
            string chuoi27=chuoi26.Substring(1,3);
            Console.WriteLine(chuoi27);
            //tolower:tra ve chu thuong
            string chuoi28 = "ok con DE";
            chuoi28 = chuoi28.ToLower();
            Console.WriteLine(chuoi28);
            chuoi28=chuoi28.ToUpper();
            Console.WriteLine(chuoi28);
            //trim: xoa khoang trang o dau va cuoi 
            string chuoi29 = "      rtrh        ";
            chuoi29=chuoi29.Trim();
            Console.WriteLine(chuoi29);
            //trimend:xoa khoang trang o cuoi chuoi
            string chuoi30 = "         23234   3434   ";
            chuoi30 = chuoi30.TrimEnd();
            Console.WriteLine(chuoi30);
            chuoi30 = chuoi30.TrimStart();
            Console.WriteLine(chuoi30);
            //split:tach chuoi
            string chuoi31 = @"D:\hoc\AI";
            string[] lst = chuoi31.Split('\\');
            Console.WriteLine(lst[0]);
            Console.WriteLine(lst[1]);
            Console.WriteLine(lst[2]);
            //join string
            string chuoi32 = string.Join("++", lst);
            Console.WriteLine(chuoi32);
            Console.ReadLine();

        }
    }
}
