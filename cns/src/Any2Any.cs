/**
 * Copyright (c) 2011-2016, Mobangjack 莫帮杰 (mobangjack@foxmail.com).
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
 
 
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
