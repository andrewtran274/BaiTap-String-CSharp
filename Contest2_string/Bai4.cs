using System;


//Tách từ: Tách một chuỗi thành các từ và in ra số lượng từ.
namespace Contest2_string
{
    internal class Bai4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao mot chuoi: ");
            string input = Console.ReadLine();
            string[] strArr = input.Split(' ');
            int countWord = strArr.Length;
            Console.WriteLine($"So luong tu trong chuoi {input} la {countWord}");
        }
    }
}
