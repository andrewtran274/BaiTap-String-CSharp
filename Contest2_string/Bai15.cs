using System;

//Chuẩn hóa tên: Nhập một chuỗi họ tên từ người dùng và
//chuẩn hóa tên theo định dạng: "Họ Tên".

namespace Contest2_string
{
    internal class Bai15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap Ho ten: ");
            string input = Console.ReadLine();

            string[] strArray = input.Split(' ');

            for(int i = 0; i < strArray.Length; i++)
            {
                strArray[i] = Char.ToUpper(strArray[i][0]) + strArray[i].Substring(1).ToLower();
            }

            string result = string.Join(" ", strArray);

            Console.WriteLine($"Chuoi sau khi chuan hoa la {result}");
        }
    }
}
