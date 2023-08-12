using System;


//Đếm số nguyên âm: Viết chương trình nhập một chuỗi từ
//người dùng và đếm số lượng nguyên âm trong chuỗi.

namespace Contest2_string
{
    internal class Bai13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap Chuoi: ");
            string input = Console.ReadLine();

            char[] chars = input.ToCharArray();
            int count = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '-' && Char.IsDigit(chars[i + 1]))
                {
                    count++;
                }
            }

            Console.WriteLine($"So Luong So Am trong chuoi {input} la {count}");
        }
    }
}
