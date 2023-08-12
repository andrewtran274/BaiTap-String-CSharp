using System;

//Kiểm tra Palindrome: Kiểm tra xem một chuỗi có phải là palindrome (đối xứng) hay không và in ra kết quả.
namespace Contest2_string
{
    internal class Bai6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap Vao 1 Chuoi: ");
            string input = Console.ReadLine();

            for(int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    Console.WriteLine("Chuoi Khong Doi Xung!");
                    return;
                }
            }
            Console.WriteLine("Chuoi Doi Xung!");
        }
    }
}
