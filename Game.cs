using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

using static System.Console;

namespace WhatsNewWithCSharp7
{
    static class Game
    {
        static (int x, int y) coord(string coordinate)
        {
            var match = Regex.Match(coordinate, @"(?<x>\d+)\,(?<y>\d+)");
            int x = default;
            if (int.TryParse(match.Groups["x"].Value, out x) && int.TryParse(match.Groups["y"].Value, out var y))
            {
                return (x,y);
            }
            throw new ArgumentException("invalid format");
        }

        public static void Run(string[] args)
        {
            object[,] map = {
                { 0,0,0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0,"X",0 },
                { 0,0,0,0,0,0,0,0,0,0 },
                { 0,0,"X",0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0,0,0 },
                { 0,"Y",0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,"Y",0,0,0 },
                { 0,0,0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0,0,0 }
            };

            ref object Map(int x, int y)
            {
                return ref map[x, y];
            }

            void Print(int i = 0)
            {
                if (i == map.GetLength(0)) return;
                for(var j = 0; j<map.GetLength(1); j++)
                {
                    switch(map[i,j])
                    {
                        case int x when x>0:
                            Write(x);
                            break;
                        default:
                            Write(".");
                            break;
                    }
                }
                WriteLine();
                Print(i+1);
            }

            while(true)
            {
                try
                {
                    Print();
                    Write("Coordinate:"); var coordinate = ReadLine();
                    // var xy = coord(coordinate);
                    // var (x,y) = coord(coordinate);
                    // var p = Point.parse(coordinate);
                    var (x1, y1) = Point.parse(coordinate);
                    WriteLine($"x1={x1}, y1={y1}");

                    ref var o = ref Map(x1, y1); // potrei usare this
                    // if (o is int acqua)
                    // {
                    //     WriteLine("Acqua");
                    // }
                    // else if (o is string boat)
                    // {
                    //     if (boat == "X")                        
                    //     {
                    //         WriteLine("BOOM");
                    //     }
                    //     else if (boat == "Y")
                    //     {
                    //         WriteLine("Cacchio");                            
                    //     }
                    // }
                    switch(o)
                    {
                        case int acqua:
                            WriteLine("Acqua");
                            o = acqua+1;
                            break;
                        // case string boat:
                        //     if (boat == "X")
                        //     {
                        //         WriteLine("BOOM");
                        //     }
                        //     else if (boat == "Y")
                        //     {
                        //         WriteLine("CACCHIO");
                        //     }
                        //     break;
                        case string boat when boat == "X":
                            WriteLine("BOOM");
                            o = 1;
                            break;
                        case string boat when boat == "Y":
                            WriteLine("CACCHIO");
                            o = 1;
                            break;
                    }
                }
                catch
                {

                }
            }
        }
    }
}
