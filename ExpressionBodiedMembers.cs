using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

using static System.Console;

namespace WhatsNewWithCSharp7
{
    static class ExpressionBodiedMembers
    {
        public static void Run(string[] args)
        {
            var b = new Billion(3_030_434_212);
            WriteLine(b);
        }
    }

    class Billion 
    {
        private decimal x;

        public decimal X {
            get => x/1_000_000_000M;
            set => x = value > 0 ? value : throw new ArgumentException("onlypositive");
        }
        public Billion(decimal x) => X = x;

        override public string ToString() => $"{X:0.000} billions";
    }
}

