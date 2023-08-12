using System;


//Kiểm tra anagram: Viết chương trình kiểm tra xem hai
//chuỗi có phải là anagram (hoán vị) của nhau hay
//không và in ra kết quả.

namespace Contest2_string
{
    internal class Bai16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap Chuoi 1: ");
            string input1 = Console.ReadLine();
            Console.WriteLine("Nhap Chuoi 2: ");
            string input2 = Console.ReadLine();

            if(CheckAnagram(input1, input2))
            {
                Console.WriteLine("La chuoi Anagram");
            }
            else
            {
                Console.WriteLine("Khong Phai Chuoi Anagram");
            }
        }

        static bool CheckAnagram(string input1, string input2)
        {
            if(input1.Length != input2.Length)
            {
                return false;
            }

            int[] charArray = new int[256];

            for(int i= 0; i < input1.Length; i++)
            {
                charArray[input1[i]]++;
                charArray[input2[i]]--;
            }


            for(int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
