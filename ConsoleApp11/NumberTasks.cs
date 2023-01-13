using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    internal class NumberTasks
    {
        internal int EnterNumber()
        {
            int n = int.Parse(Console.ReadLine());

            return n;
        }
        internal int GetReverseNumber(int number)
        {
            int reversenumber = 0;
            int n = (int)Math.Log10(number);

            while (number!=0)
            {
                int r= number % 10;
                number /= 10;
                reversenumber = +r * (int)Math.Pow(10, n--);
            }
            return reversenumber;
        }
    }
}
