using System;

//Tính độ dài: Viết chương trình tính và in ra độ dài của một chuỗi cho trước.

namespace Contest2_string
{
    internal class Bai1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap 1 Chuoi Bat Ki: ");
            string input = Console.ReadLine();
            Console.WriteLine($"Do Dai cua chuoi {input} la {input.Length}");
        }
    }
}
