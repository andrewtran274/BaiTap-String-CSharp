using System;

//Tìm từ: Tìm và in ra vị trí đầu tiên của một từ cụ thể trong một chuỗi.

namespace Contest2_string
{
    internal class Bai7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap Chuoi: ");
            string input = Console.ReadLine();
            Console.WriteLine("Nhap Tu Can TIm: ");
            string str = Console.ReadLine();


            int index = input.IndexOf(str);

            if(index > 0 )
            {
                Console.WriteLine($"tu can tim o vi tri {index} trong chuoi {input}");
            }
            else
            {
                Console.WriteLine("Khong tim thay tu can tim!");
            }
        }
    }
}
