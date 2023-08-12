using System;

//Kiểm tra rỗng: Kiểm tra xem một chuỗi có phải là rỗng hay không và in ra kết quả.

namespace Contest2_string
{
    internal class Bai3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap Vao 1 Chuoi: ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Chuoi Rong!");
            }
            else
            {
                Console.WriteLine("Chuoi Khong Rong!");
            }
        }
    }
}
