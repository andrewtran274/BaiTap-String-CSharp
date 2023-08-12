using System;


//Loại bỏ ký tự trùng lặp: Nhập một chuỗi từ người dùng, loại bỏ các ký tự trùng lặp trong chuỗi và in ra chuỗi đã chỉnh sửa.

namespace Contest2_string
{
    internal class Bai17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap Chuoi: ");
            string input = Console.ReadLine();

            string result = RemoveDuplicateChar(input);

            Console.WriteLine($"Chuoi Sau khi xoa cac ki tu trung: {result}");
        }


        static string RemoveDuplicateChar(string input)
        {
            string result = "";

            for(int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                bool checkDuplicate = false;

                for(int j = 0; j < i; j++)
                {
                    if (input[j] == currentChar)
                    {
                        checkDuplicate = true;
                    }
                }

                if(!checkDuplicate )
                {
                    result += currentChar;
                }
            }

            return result;
        }
    }
}
