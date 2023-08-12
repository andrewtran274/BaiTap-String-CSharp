using System;

//Kiểm tra chuỗi con liên tiếp: Nhập một chuỗi từ người dùng, kiểm tra xem chuỗi có chứa chuỗi con liên tiếp nào không và in ra kết quả.

namespace Contest2_string
{
    internal class Bai18
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap Chuoi: ");
            string str = Console.ReadLine();

            Console.WriteLine("Nhap chuoi con: ");
            string subStr = Console.ReadLine();


            if(CheckSubString(str, subStr))
            {
                Console.WriteLine("Ton Tai Chuoi Con Lien Tiep");
            }
            else
            {
                Console.WriteLine("Khong Ton Tai");
            }
        }

        static bool CheckSubString(string str, string subStr)
        {
            for(int i = 0; i <= str.Length - subStr.Length; i++)
            {
                if(str.Substring(i, subStr.Length) == subStr)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
