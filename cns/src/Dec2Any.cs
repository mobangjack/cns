using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionOfNumberSystems
{
    class Dec2Any
    {

        public static string convert(ulong numDec, byte dstSys)
        {
            Stack<char> digitCharStack = new Stack<char>();
            ulong quotient = numDec;
            byte remainder = 0;
            while(quotient != 0)
            {
                remainder = (byte)(quotient % dstSys);
                quotient = quotient / dstSys;
                digitCharStack.Push(Digits.Any(remainder));
            }
            StringBuilder stringBuilder = new StringBuilder(digitCharStack.Count);
            while(digitCharStack.Count > 0)
            {
                stringBuilder.Append(digitCharStack.Pop());
            }
            return stringBuilder.ToString();
        }

    }
}
