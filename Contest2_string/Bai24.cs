using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//dao nguoc chuoi bang 2 con tro
namespace Contest2_string
{
    internal class Bai24
    {
        static void Main(string[] args)
        {

        }

        public class Solution
        {
            public void ReverseString(char[] s)
            {
                int left = 0;
                int right = s.Length - 1;

                while (left < right)
                {
                    char tempChar = s[left];
                    s[left] = s[right];
                    s[right] = tempChar;

                    left++;
                    right--;
                }
            }
        }
    }
}
