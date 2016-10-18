using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionOfNumberSystems
{
    class Assertion
    {

        public static void assertDigitChar(char digitChar)
        {
            if (!((digitChar >= '0' && digitChar <= '9') || (digitChar >= 'a' && digitChar <= 'z') || (digitChar >= 'A' && digitChar <= 'Z')))
            {
                throw new ArgumentException("The digitChar should be any of '0'-'9' or 'a[A]'-'z[Z]");
            }
        }

        public static void assertFmt(byte fmt)
        {
            if (fmt < 2 || fmt > 36)
            {
                throw new ArgumentException("The fmt should be any of 2 to 36 inclusively");
            }
        }
    }
}
