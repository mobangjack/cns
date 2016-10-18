using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConversionOfNumberSystems
{
    class Any2Dec
    {

        public static ulong convert(string numStr, byte orgSys)
        {
            ulong result = 0;
            for (int i = 0; i < numStr.Length; i++)
            {
                result = result * orgSys + (ulong)(Digits.Dec(numStr.ElementAt(i)));
            }
            return result;
        }

    }
}
