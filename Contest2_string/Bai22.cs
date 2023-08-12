using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Valid Chuoi Doi Xung

namespace Contest2_string
{
    internal class Bai22
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap Chuoi: ");
            string s = Console.ReadLine();
        }

        static bool checkDoiXung(string s)
        {
            string res = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetterOrDigit(s[i]))
                {
                    res += s[i];
                }
            }
            res = res.ToLower();
            for(int i = 0; i < res.Length / 2; i++)
            {
                if (res[i] != res[res.Length - 1 - i]) { 
                    return false;
                }
            }
            return true;
        }
    }
}
