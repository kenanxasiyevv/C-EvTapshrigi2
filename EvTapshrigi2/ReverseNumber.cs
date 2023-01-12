using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvTapshrigi2
{
    internal class ReverseNumber
    {
        internal int Number(int number)
        {
            int reversenumber = 0;
            int r;
            int count = (int)Math.Log10(number);

            while (number != 0)
            {
                r = number % 10;
                number /= 10;
                reversenumber += r * (int)Math.Pow(10, count);
                count--;
            }

            return reversenumber;
        }
    }
}
