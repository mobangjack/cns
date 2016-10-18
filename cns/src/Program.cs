using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionOfNumberSystems
{
    class Program
    {

        public static void Test(string numStr, char orgSys, char dstSys)
        {
            Console.WriteLine(Any2Any.convert(numStr, orgSys, dstSys));
        }

        public static void Test(string[] args)
        {
            Test(args[0], args[1].ElementAt(0), args[2].ElementAt(0));
        }

        public static void Main(string[] args)
        {
            Test(args);
        }
    }
}
