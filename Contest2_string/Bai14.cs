using System;

//Xoá khoảng trắng thừa: Nhập một chuỗi từ người dùng và loại bỏ khoảng trắng thừa ở đầu và cuối chuỗi, sau đó in ra chuỗi đã chỉnh sửa.

namespace Contest2_string
{
    internal class Bai14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap Chuoi: ");
            string input = Console.ReadLine();
            Console.WriteLine($"Chuoi Sau Khi chuan hoa la {input.Trim()}");
        }
    }
}
