using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

using static System.Console;

namespace WhatsNewWithCSharp7
{
    static class Tuples
    {
        public static void Run(string[] args)
        {
            var letters = ("a", "b");

            (string Alpha, string Beta) namedLetters = ("a", "b");

            var alphabetStart = (Alpha: "a", Beta: "b");    

            (string First, string Second) firstLetters = (Alpha: "a", Beta: "b");

            (double x, double y) point(double r, double alpha)
            {
                return (r*Math.Cos(alpha), r*Math.Sin(alpha));
            }

            (double avg, double min, double max) stats(IEnumerable<double> values)
            {
                return (values.Average(), values.Min(), values.Max());
            }

            // deconstruction
            var (x, y) = point(10, 0.866);
            WriteLine($"{x:0.000},{y:0.000}");

            var (a,b,c) = stats(new double[] { 3,6,5,4,7 });
            WriteLine($"{a:0.000},{b:0.000},{c:0.000}");

            // tuple
            var s = stats(new double[] { 3,6,5,4,7 });
            WriteLine($"{s.avg:0.000},{s.min:0.000},{s.max:0.000}");

            var (m,_, p) = stats(new double[] { 3,6,5,4,7 });
            WriteLine($"{a:0.000},{b:0.000},{c:0.000}");

            // infer tuple element
            var z = (x,y);
            var xx = z.Item1; // 7.0
            // var xx = z.x;  // 7.1+

            // When calling methods with out parameters.
            // just to test if it is a number
            if (int.TryParse("4", out _))
            {}

            // In a pattern matching operation with the is and switch statements.


            // As a standalone identifier when you want to explicitly identify the value of an assignment as a discard.
            _ = stats(null);
        }
    }
}

