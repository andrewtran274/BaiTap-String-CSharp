using System;


//Tính độ dài của từ dài nhất: Viết chương trình nhập một chuỗi từ người dùng và in ra độ dài của từ dài nhất trong chuỗi đó.

namespace Contest2_string
{
    internal class Bai11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap Chuoi: ");
            string input = Console.ReadLine();
            string[] strArray = input.Split(' ');
            int maxLength = 0;
            foreach (string str in strArray)
            {
               if(str.Length > maxLength)
                {
                    maxLength = str.Length;
                }
            }

            Console.WriteLine($"Tu dai nhat trong chuoi {input} co do dai la {maxLength}");
        }
    }
}
