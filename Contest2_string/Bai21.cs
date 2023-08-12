using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//kiem tra ki tu nhap có đủ [], {}, () hay không

namespace Contest2_string
{
    internal class Bai21
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap Vao 1 Chuoi: ");
            string s = Console.ReadLine();

            if (IsValid(s))
            {
                Console.WriteLine($"Result: True");
            }
            else
            {
                Console.WriteLine("Result: False");
            }
        }

        static bool IsValid(string s)
        {
            while(s.Contains("()") || s.Contains("[]") || s.Contains("{}"))
            {
                s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");
            }

            return s.Length == 0;
        }
    }
}
