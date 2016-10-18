using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionOfNumberSystems
{
    class Digits
    {
        public const string digits = "0123456789abcdefghijklmnopqrstuvwxyz";

        public static int Dec(char c)
        {
            return digits.IndexOf(c);
        }

        public static char Any(int i)
        {
            return digits.ElementAt(i);
        }
    }
}
