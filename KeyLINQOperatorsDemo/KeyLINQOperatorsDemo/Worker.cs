using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyLINQOperatorsDemo
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            var listOfIntegers = new List<int>{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            
            var listOfIntegers2 = new List<int> ();

            bool hasAny = listOfIntegers.Any();
            bool hasAny2 = listOfIntegers2.Any();
            bool hasAny3 = listOfIntegers.Any(x => x == 3);
            bool has12 = listOfIntegers.Any(x => x == 12);

            Console.WriteLine("Any");
            Console.WriteLine(hasAny);
            Console.WriteLine(hasAny2);
            Console.WriteLine(hasAny3);
            Console.WriteLine(has12);

            Console.WriteLine("\n-----\n");

            var take5 = listOfIntegers.Take(5)
                .Select(x => x * 10);
            Console.WriteLine("Take");
            foreach (int val in take5)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine("\n-----\n");

            var multipleValueList = new List<int> { 1, 1, 2, 3, 4, 45, 6, 7, 8, 9, 0, 0 };
            var outputDistinct = multipleValueList.Distinct().Select(x => x * 9);
            Console.WriteLine("Distinct");
            foreach (int val in outputDistinct)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine("\n-----\n");

            var codes = new List<string> { "AL", "AK", "AZ", "AR", "CA", "CO", "CT" };
            var states = new List<string> { "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut" };
            var codeWithStates = codes.Zip(states, (code, state) => code + ":" + state);
            foreach (var item in codeWithStates)
            {
                Console.WriteLine(item);
            }
        }
    }
}
