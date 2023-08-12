using System;
// Đảo ngược từ trong chuỗi: Nhập một chuỗi từ người dùng,
// đảo ngược thứ tự các từ trong chuỗi nhưng giữ nguyên thứ
// tự của các ký tự đặc biệt và khoảng trắng, sau đó in ra kết quả.


namespace Contest2_string
{
    internal class Bai19
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap Chuoi: ");
            string input = Console.ReadLine();
            char[] charResult = new char[input.Length];
            string tmpStr = "";
            for(int i = 0; i < charResult.Length; i++)
            {
                if (!char.IsLetterOrDigit(input[i]))
                {
                    charResult[i] = input[i];
                    
                }
                else
                {
                    charResult[i] = '0';
                    tmpStr += input[i];
                }
            }
            Console.WriteLine(tmpStr);
            Console.WriteLine(charResult.ToString());
            int count = 0;
            for(int i = 0; i < charResult.Length; i++)
            {
                if (charResult[i] == '0')
                {
                    charResult[i] = tmpStr[tmpStr.Length - 1 - count];
                    count++;
                }
            }


            Console.WriteLine($"Vay chuoi khi dao nguoc la: {new string (charResult)}");
        }
    }
}
