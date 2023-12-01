using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace bai18._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //path.combine ket hop voi cac chuoi thanh duong dan
            string path = Path.Combine(@"D:\", "hoc", "AI");
            Console.WriteLine(path);
            //path.changeExtension() thay doi phan mo rong cua duong dan
            string path2 = Path.ChangeExtension(path, "pdf");
            Console.WriteLine(path2);
            //path.directoryname tra ve thu muc chuaw file theo duong dan
            string thumuc=Path.GetDirectoryName(path);
            Console.WriteLine(thumuc);
            //path.getextension: lay phan mo rong
            string morong=Path.GetExtension(path2);
            Console.WriteLine(morong);
            //path.getfilenam: trar ve ten file
            string path5=Path.GetFileName(path);
            Console.WriteLine(path5);
            //lay duong dan day du
            string path6 = Path.GetFullPath(@"thumuc\ok.txt");
            Console.WriteLine(path6);
            //truong hop2
            string path7 = Path.GetFullPath(@"D:\thumuc\ok.txt");
            Console.WriteLine(path7);
            //lay goc cua duong dan
            string path8=Path.GetPathRoot(@"D:\thumuc\ok.txt");
            Console.WriteLine(path8);
            //lay duong dan den mot so thu muc dac biet cua he thong
            //co the dung phuong thuc enviroment.getfolderpath
            //vi du: lay thu muc MyMusic, MyDocument
            string pathdacbiet = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Console.WriteLine(pathdacbiet);
            Console.ReadLine();
        }
    }
}
