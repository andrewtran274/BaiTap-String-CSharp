using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Kiem tra chuoi con dai nhat

namespace Contest2_string
{
    internal class Bai20
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Nhap Chuoi: ");
            string s = Console.ReadLine();

            int res = LengthOfLongestSubstring(s);

            Console.WriteLine($"Do Dai Cua Chuoi Con Dai Nhat la: {res}");

        }
        static int LengthOfLongestSubstring(string s)
        {
            int maxLength = 0;
            int left = 0;
            int right = 0;

            HashSet<char> charSet = new HashSet<char>();

            while (right < s.Length)
            {
                if (!charSet.Contains(s[right]))
                {
                    charSet.Add(s[right]);
                    maxLength = Math.Max(maxLength, right - left + 1);
                    right++;
                }
                else
                {
                    charSet.Remove(s[left]);
                    left++;
                }
            }


            return maxLength;
        }
    }
}
