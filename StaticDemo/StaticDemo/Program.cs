using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string selection = string.Empty;

            while (selection != "q" && selection != "Q")
            {
                Console.Write("Enter C)elsius or F)ahrenheit or Q)uit");
                selection = Console.ReadLine();
                double fahrenheit = 0, celsius = 0;
                switch (selection)
                {
                    case "C":
                    case "c":
                        Console.Write("Please enter the temperature in Celsius: ");
                        fahrenheit = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine());
                        Console.WriteLine("Temperature in fahrenheit: {0:f2}", fahrenheit);
                        break;

                    case "F":
                    case "f":
                        Console.Write("Please enter the temperature in Fahrenheit: ");                        
                        celsius = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine());
                        Console.WriteLine("Temperature in fahrenheit: {0:f2}", celsius);
                        break;

                    case "Q":
                    case "q":
                        break;

                    default:
                        Console.WriteLine("Please try again");
                        break;
                }
            }
        }
    }
}
