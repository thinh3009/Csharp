using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "abcdefghijklmnopqrstuvwxyz";
            string b = "zxcvbnmasdfghjklqwertyuiop";
            Console.WriteLine("nhap chu can ma hoa: ");
            string chuoiinput=Console.ReadLine();//viet gon cua doc
            string chuoioutput = "";
            foreach(char i in chuoiinput)
            {
                int indexkytu=a.IndexOf(i);//tao bien de tim index
                Console.WriteLine(b[indexkytu]);//dua b vao index de ma hoa
                chuoioutput += b[indexkytu];//them vao chuoi moi
            }
            Console.WriteLine(chuoioutput);
            Console.ReadKey();

        }
    }
}
