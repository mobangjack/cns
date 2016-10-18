using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionOfNumberSystems
{
    class Any2Any
    {
        public static string convert(string numStr, byte orgSys, byte dstSys)
        {
            ulong dec = Any2Dec.convert(numStr, orgSys);
            string any = Dec2Any.convert(dec, dstSys);
            return any;
        }

        public static string convert(string numStr, char orgSys, char dstSys)
        {
            return convert(numStr, (byte)(Digits.Dec(orgSys) + 1), (byte)(Digits.Dec(dstSys) + 1));
        }
    }
}
