using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khai bao dictionary
            Dictionary<int,string>dic= new Dictionary<int,string>();
            //khoi tao va gan gia tri
            Dictionary<int,string>dic2=new Dictionary<int, string>() { { 1, "thinh" }, { 2,"okeconde"} };
            //key:bien so (string)
            //value:chung minh(int)
            Dictionary<string, int> dic3 = new Dictionary<string, int>() { { "20H2323", 433443 }, { "34e343", 323423 } };
            //add:them phan tu vao dis
            dic.Add(1, "thinh");
            dic.Add(2, "vybeo");
            //duyet dic
            foreach(KeyValuePair<int,string> kvp in dic2)
            {
                Console.WriteLine(kvp);
                Console.WriteLine(kvp.Key);
                Console.WriteLine(kvp.Value);
                Console.WriteLine("key ={0},value={1}",kvp.Key,kvp.Value);
            }
            //dic.containkey:kiem tra key co ton tai khong
            bool kq=dic.ContainsKey(1);
            Console.WriteLine("kq="+kq);
            //dic.containvalue
            bool kq2 = dic.ContainsValue("okconde");
            Console.WriteLine("kq=" + kq2);
            //dic[key]: lay value tu key
            string name = dic[1];
            Console.WriteLine(name);
            //gan gia tri
            dic[2] = "thinh ko dep trai";
            Console.WriteLine(dic[2]);
            //xoa phan tu:
            dic.Remove(2);
            Console.WriteLine("dic sau khi xoa: ");
            foreach(KeyValuePair<int,string> kpv in dic)
            {
                Console.WriteLine(kpv);
            }
            //xoa toan bo
            dic.Clear();
            Console.WriteLine("so phan tu cua dic: "+dic.Count);
            //chuyen value dic sang list
            Dictionary<string, int> dic4 = new Dictionary<string, int>() 
            { { "20H2323", 433443 }, { "34e343", 323423 } };
            List<int> ds=new List<int>();
            ds=dic4.Values.ToList();//dua values cua dic4 vao list moi
            Console.WriteLine("danh sach: ");
            foreach(int i in ds)
            {
                Console.Write(i + "\t");
            }
            //chuyen key dic sang list
            List<string> dskey = new List<string>();
            dskey=dic4.Keys.ToList();
            Console.WriteLine("danh sach key la: ");
            foreach(string s in dskey)
            {
                Console.WriteLine(s+"\t");
            }
            Console.ReadKey();
        }
    }
}
