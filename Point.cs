using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

using static System.Console;

namespace WhatsNewWithCSharp7
{
    struct Point
    {
            
        public static Point parse(string coordinate)
        {
            var match = Regex.Match(coordinate, @"(?<x>\-?\d+)\,(?<y>\-?\d+)");
            if (int.TryParse(match.Groups["x"].Value, out var x) && int.TryParse(match.Groups["y"].Value, out var y))
            {
                return new Point(x, y);
            }
            throw new ArgumentException("invalid format");
        }

        public Point(int x, int y) => (X,Y) = (x >= 0 ? x : throw new ArgumentException("x"), y >= 0 ? y : throw new ArgumentException("y"));

        public int X;
        public int Y;

        public void Deconstruct(out int x, out int y) 
        { 
            x = X; y = Y; 
        }
    }
}
