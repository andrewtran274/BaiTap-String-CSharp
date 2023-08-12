using System;


//Tìm số lần xuất hiện của từ: Nhập một chuỗi và một
//từ từ người dùng, sau đó đếm và in ra số lần xuất hiện
//của từ trong chuỗi.


namespace Contest2_string
{
    internal class Bai12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap Chuoi: ");
            string input = Console.ReadLine();

            Console.WriteLine("Nhap tu can tim: ");
            string str = Console.ReadLine();

            int count = 0;

            string[] strArray = input.Split(' ');
            
            for(int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i].Equals(str))
                {
                    count++;
                }

            }
            Console.WriteLine($"Vay co {count} tu {str} trong chuoi {input}");
        }
    }
}
