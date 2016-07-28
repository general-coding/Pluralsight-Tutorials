using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int myAge = 21;
            int x = 5;
            double myHourlyRate = 150.00;
            var myName = "Puneeth";

            Console.WriteLine("myAge: {0}, x: {1}, myHourlyRate: {2}, myName: {3}", myAge, x, myHourlyRate, myName);

            myAge = 35;
            x = 20;
            myHourlyRate = 85.00;
            myName = "Jason";

            Console.WriteLine("myAge: {0}, x: {1}, myHourlyRate: {2}, myName: {3}", myAge, x, myHourlyRate, myName);
        }
    }
}
