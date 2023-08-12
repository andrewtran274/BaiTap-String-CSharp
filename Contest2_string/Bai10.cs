using System;

//Nối chuỗi: Nhập vào hai chuỗi và nối chúng lại thành một chuỗi mới, sau đó in ra kết quả.

namespace Contest2_string
{
    internal class Bai10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap Chuoi 1: ");
            string input1 = Console.ReadLine();

            Console.WriteLine("Nhap chuoi 2: ");
            string input2 = Console.ReadLine();

            Console.WriteLine($"Noi 2 chuoi {input1} va {input2}: {string.Concat(input1, input2)}");
        }
    }
}
