using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("moi nhap mat khau co it nhat 6 ki tu: ");
            string mk=Console.ReadLine();
            bool check = true;
            int demso = 0, demkitu = 0;
            while (check)
            {
                foreach(char c in mk)
                {
                    if (char.IsDigit(c))
                    {
                        demso++;
                    }
                    else if(char.IsLetter(c))
                    {
                        demkitu++;
                    }

                }
                Console.WriteLine(demso);
                Console.WriteLine(demkitu);
                if (demso * demkitu != 0 && mk.Length>=6)
                {
                    check = false;
                }
                else
                {
                    Console.WriteLine("nhap lai mat khau");
                    mk=Console.ReadLine();
                    check = true;
                }
            }
            Console.WriteLine("mk la: "+mk);

            string login;
            Console.WriteLine("moi nhap vao mk: ");
            login = Console.ReadLine();
            int demlogin = 0;
            while (true)
            {
                bool kq=mk.Equals(login);
                if (kq)
                {
                    Console.WriteLine("dang nhap thanh cong");
                    break;
                }
                else
                {
                    demlogin++;
                    if (demlogin < 5)
                    {
                        Console.WriteLine("nhap lai mk toi da 5 lan: "+demlogin);
                        login = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("ban da nhap sai qua 5 lan");
                        break;
                    }
                }
            }
            Console.ReadLine();
            
        }
    }
}
