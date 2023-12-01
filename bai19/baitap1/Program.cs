using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap username va pass: ");
            Dictionary<string,string> dic= new Dictionary<string,string>();
            dic.Add("thinh", "123345");
            dic.Add("vybeo", "123345");
            dic.Add("namtao", "123345");
            dic.Add("bacdau", "123345");
            dic.Add("ongtroi", "123345");
            Console.WriteLine("nhap username: ");
            string keydic=Console.ReadLine();
            Console.WriteLine("nhap pass: ");
            string valuedic=Console.ReadLine();
            if(dic.ContainsKey(keydic)==false)
            {
                Console.WriteLine("khong ton tai");
            }
            else
            {
                if (dic[keydic] == valuedic)
                {
                    Console.WriteLine("dang nhap thanh cong");
                }
                else {
                    Console.WriteLine("nhap sai");
                }
            }
            
            Console.ReadLine();
        }
    }
}
