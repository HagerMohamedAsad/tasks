using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covert_hexa_to_decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the hex number");
            string hex = Console.ReadLine();
            char c;
            int DecimalNumber = 0;
            int k;
            double i = 0;
            double r = 0;
            for (int h = hex.Length-1 ; h>=0 ;h--)
            {
                c=hex[h];
                if ((c == 'A') || (c == 'a')) k = 10;
                else if ((c == 'B') || (c == 'b')) k = 11;
                else if ((c == 'C') || (c == 'c')) k = 12;
                else if ((c == 'D') || (c == 'd')) k = 13;
                else if ((c == 'E') || (c == 'e')) k = 14;
                else if ((c == 'F') || (c == 'f')) k = 15;
                else k = c - '0';
                r = (double)k * (Math.Pow(16, i));
                DecimalNumber = DecimalNumber + (int)r;
                i++;
            }

            Console.WriteLine("the decimal is {0}", DecimalNumber);
        }
    }
}
