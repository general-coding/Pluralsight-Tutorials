using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int myLittleHorses = 0;
            do
            {
                Console.WriteLine("myLittleHorses = {0}", myLittleHorses);
                myLittleHorses++;
            } while (myLittleHorses < 10);
        }
    }
}
