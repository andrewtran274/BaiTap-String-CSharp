using System;
using System.Linq;

//Đảo ngược: Viết chương trình đảo ngược một chuỗi cho trước và in ra kết quả.
namespace Contest2_string
{
    internal class Bai2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap Mot chuoi bat ki: ");
            string input = Console.ReadLine();
            char[] charArr = input.ToCharArray();
            Array.Reverse(charArr);
            string result = new string(charArr);
            Console.WriteLine($"Chuoi {input} sau khi dao nguoc la {result}");
        }
    }
}
