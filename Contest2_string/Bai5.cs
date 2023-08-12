using System;

//Thay thế: Viết chương trình thay thế tất cả các ký tự
//khoảng trắng trong chuỗi bằng dấu gạch ngang và in ra kết quả.

namespace Contest2_string
{
    internal class Bai5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao mot chuoi bat ki: ");
            string input = Console.ReadLine();

            string result = "";

            char[] charArray = input.ToCharArray();

            foreach (char c in charArray)
            {
                if(c != ' ')
                {
                    result += c;
                }
                else
                {
                    result += '-';
                }
            }

            Console.WriteLine($"Chuoi {input} Sau khi cthay the la {result}");
        }
    }
}
