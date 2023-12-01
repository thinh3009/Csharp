using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
namespace bai18._1_lamviecFile
{
    internal class Program
    {
        static void dsthumucFile(string path)
        {
            string[] thuMuc=Directory.GetDirectories(path);
            string[] files= Directory.GetFiles(path);
            //xuat ds file
            foreach(string s in files)
            {
                Console.WriteLine(s);
            }
            //xuat thu muc
            foreach(string m in thuMuc)
            {
                Console.WriteLine(m);
                dsthumucFile(m);
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo curr = new DirectoryInfo(".");//lay duong dan hien tai
            Console.WriteLine(curr.FullName);

            DirectoryInfo duongdan=new DirectoryInfo("D:\\hoc\\anh van\\từ vựng");
            Console.WriteLine(duongdan.FullName);
            //lay ten thu muc
            Console.WriteLine(duongdan.Name);
            //lay thu muc cha
            Console.WriteLine(duongdan.Parent);
            //lay thuocv tinh\
            Console.WriteLine(duongdan.Attributes);
            //lay thoi gian tao thu muc
            Console.WriteLine(duongdan.CreationTime);
            //tao thu muc
            //cach1
            DirectoryInfo tm1=new DirectoryInfo("D:\\newFile");
            tm1.Create();
            //cach2
            string tm2 = @"D:\\newFile2";
            Directory.CreateDirectory(tm2 );
            //kiem tra ton tai flie khong
            string path1 = @"D:\\newFile2";
            if (Directory.Exists(path1))
            {
                Console.WriteLine("thu muc da ton tai");
            }
            else
            {
                Console.WriteLine("thu muc chua co");
            }
            //5.xoa thu mua
            string path2= @"D:\\newFile2";
            Directory.Delete(path2);
            //tra ve ds file trong path
            string path3 = "D:\\game\\Epic Games\\DirectXRedist";
            string[] mang = Directory.GetFiles(path3);//tao mang de chua ds file
            Console.WriteLine($"ds file {path3}");
            foreach (string s in mang)
            {
                Console.WriteLine(s);
            }
            //tra ve ds file trong path
            string path4 = "D:\\game";
            string[] dsthumuc= Directory.GetDirectories(path4);
            Console.WriteLine($"ds file {path4}");
            foreach (string s in dsthumuc)
            {
                Console.WriteLine(s);
            }

            //goi ham
            string path5 = @"D:\game\Riot Games";
            Console.WriteLine($"ds file va thu muc {path5}");
            dsthumucFile(path5 );

            //tim kiem file
            DirectoryInfo mydata= new DirectoryInfo("C:\\Program Files\\Microsoft SQL Server\\MSSQL16.SQLEXPRESS\\MSSQL\\Backup");
            FileInfo[] txtfile= mydata.GetFiles("*.bak",SearchOption.TopDirectoryOnly);
            //so file thoa man dieukien
            Console.WriteLine("tim thay: "+txtfile.Length);
            foreach(FileInfo file in txtfile)
            {
                //day theo ten
                Console.WriteLine(file.Name);

            }
            Console.ReadKey();
        }
    }
}
