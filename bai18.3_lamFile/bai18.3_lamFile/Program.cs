using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.IO;
namespace bai18._3_lamFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //streamWriter: ghi file van ban
            FileStream fs = new FileStream("datal.txt", FileMode.Create, FileAccess.ReadWrite);
            StreamWriter wirte = new StreamWriter(fs);
            wirte.WriteLine("hello");
            wirte.Flush();
            fs.Close();

            //streamReader: doc file van ban
            fs = new FileStream("datal.txt", FileMode.Open, FileAccess.Read);
            StreamReader sread = new StreamReader(fs);
            string str = sread.ReadToEnd();
            Console.WriteLine(str);
            fs.Close();
            //binarywriter/ binaryreader:doc ghi du lieu (int bool char)
            FileStream fs2 = new FileStream("data2.txt", FileMode.Create, FileAccess.ReadWrite);
            BinaryWriter bw=new BinaryWriter(fs2);
            bw.Write(123);
            fs2.Close();

            fs2 = new FileStream("data2.txt", FileMode.Open, FileAccess.Read);
            BinaryReader br=new BinaryReader(fs2);
            var i=br.ReadInt32();
            Console.WriteLine(i);
            //using: tu dong dong file khong can close
            using (FileStream fs4 = new FileStream("data3.txt", FileMode.Create, FileAccess.ReadWrite))
            {
                BinaryWriter br4= new BinaryWriter(fs4);
                br4.Write(5656);
                StreamWriter sw4=new StreamWriter(fs4);
                sw4.Write("ok con de");
                sw4.Flush();
            }
            using(var fs4=new FileStream("data3.txt",FileMode.Open,FileAccess.Read))
            {
                BinaryReader br4=new BinaryReader(fs4);
                var x =br4.ReadInt32();
                StreamReader rd4=new StreamReader(fs4);
                var str4=rd4.ReadToEnd();
                Console.WriteLine(x);
                Console.WriteLine(str4);
            }
            //file writealltext
            string duongdan = "filemoi.txt";
            string noidung = "okokokokokokokokokok";
            File.WriteAllText(duongdan, noidung);
            //file.writeallines:ghi mot mang
            string[] noidung2 = { "conmeo", "concu", "conchum" };
            File.WriteAllLines(duongdan,noidung2);
            //file.appenallline
            string[] noidung3 = { "haha3", "haha5", "haha5" };
            File.AppendAllLines(duongdan,noidung3);
            //file.readalltext
            //doc tat ca cac dong trong file
            string noidungdoc = File.ReadAllText("filemoi.txt");
            Console.WriteLine(noidungdoc);
            //file.readallline
            string[] arrnd = File.ReadAllLines("filemoi.txt");
            foreach(string dong  in arrnd)
            {
                Console.WriteLine(dong);
            }
            Console.WriteLine(arrnd[1]);
            //file.move
            string path1 = "filemoi.txt";
            string path2 = "C:\\Users\\buidu\\OneDrive\\Máy tính\\code2\\hocCsharp\\bai18.3_lamFile\\bai18.3_lamFile\\bin\\Debug\\thumucmoi\\new.txt";
            //File.Move(path1, path2);
            //file.copy
            string path4 = "C:\\Users\\buidu\\OneDrive\\Máy tính\\code2\\hocCsharp\\bai18.3_lamFile\\bai18.3_lamFile\\bin\\Debug\\thumucmoi\\new_copy.txt";
            //File.Copy(path1, path4);

            //file.delete
            File.Delete(path4);
            Console.ReadLine();

        }
    }
}
