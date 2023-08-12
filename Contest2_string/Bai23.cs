using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contest2_string
{
    internal class Bai23
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap Chuoi: " );
            int x = int.Parse(Console.ReadLine());

            long res = Reverse(x);
            Console.WriteLine($"{res}");
        }

        static int Reverse(int x)
        {
            string str = new string(x.ToString().Trim('-').Reverse().ToArray());
            bool tryInt32 = int.TryParse(str, out int intValue);

            
            return tryInt32 ? x.ToString().Contains("-") ? intValue * -1 : intValue : 0;
        }
    }
}
