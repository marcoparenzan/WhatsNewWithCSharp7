using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

using static System.Console;

namespace WhatsNewWithCSharp7
{
    static class NumericLiterals
    {
        public static void Run(string[] args)
        {
            var mask = 0b0001_0010_0100_1000;
            WriteLine(mask == 0x1248);

            var onebillion = 1_000_000_000d; // M, f, d
            WriteLine(onebillion);
            WriteLine(onebillion.GetType());
        }
    }
}

