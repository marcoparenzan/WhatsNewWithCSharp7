using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

using static System.Console;

namespace WhatsNewWithCSharp7
{
    static class PatternMatching
    {
        public static void Run(string[] args)
        {
            var ints = new int[] { 1,2,3 };
            var strings = new string[] { "a", "b", "c" };
            var points = new Point[] { new Point(0,0), new Point(1,1 )};

            IEnumerable x = default(IEnumerable);

            switch(x)
            {
                case null:
                    WriteLine("null");
                    break;
                case IEnumerable<int> i: 
                    WriteLine("Integers");
                    break;
                case IEnumerable<string> s: 
                    WriteLine("Strings");
                    break;
                case IEnumerable<Point> p: 
                    WriteLine("Points");
                    break;
            }
        }
    }
}

