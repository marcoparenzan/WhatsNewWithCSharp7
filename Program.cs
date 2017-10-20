using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

using System.Threading.Tasks;

using System.Net.Http;

using static System.Console;

namespace WhatsNewWithCSharp7
{
    static class Program
    {
        // async static Task Main(string[] args)
        static void Main(string[] args)
        {
            var url = "https://raw.githubusercontent.com/marcoparenzan/WhatsNewWithCSharp7/master/map.txt";
            var client = new HttpClient();
            // var text = await client.GetStringAsync(url);
            var text = client.GetStringAsync(url).Result;
            var i = 0;
            var rows = text.Split("\n");
            var map = new object[rows.Length, rows.Length];
            foreach(var row in rows)
            {
                var j = 0;
                foreach(var ch in row)
                {
                    if (ch == '0') map[i,j] = 0;
                    else map[i,j] = ch.ToString();
                    j++;
                }
                i++;
            }
            
            Game.Run(map);
        }
    }
}
