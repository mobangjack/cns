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
