using System;

//Chuyển thành chữ hoa/chữ thường: Viết chương trình chuyển một chuỗi thành chữ hoa hoặc chữ thường và in ra kết quả.

namespace Contest2_string
{
    internal class Bai8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap Chuoi: ");
            string input = Console.ReadLine();

            Console.WriteLine($"chuyen thanh chu hoa: {input.ToUpper()}");
            Console.WriteLine($"chuyen thanh chu thuong: {input.ToLower()}");
        }
    }
}
