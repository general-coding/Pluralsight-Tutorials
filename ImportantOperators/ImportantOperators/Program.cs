﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = null;
            Console.WriteLine(x);

            List<string> authors = null;
            int? count = authors?nu.Count;

            string message = count == null ? "count is null" : "count is not null";

            Console.WriteLine(message);

            int howMany = authors?.Count ?? 0;
            Console.WriteLine(howMany);

            authors = new List<string>(){
                "author one", "author two"
            };

            howMany = authors?.Count??0;
            Console.WriteLine(howMany);
        }
    }
}
