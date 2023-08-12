using System;


//Tách số: Tách một chuỗi số thành các phần tử con và in ra tất cả các phần tử.

namespace Contest2_string
{
    internal class Bai9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap Vao Mot Chuoi So: ");
            string input = Console.ReadLine();

            char[] numArr = input.ToCharArray();

            Console.WriteLine();
            foreach (char c in numArr)
            {
                Console.Write(c + " ");
            }
        }
    }
}
