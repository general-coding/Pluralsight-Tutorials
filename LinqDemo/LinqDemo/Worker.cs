using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LinqDemo
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            var listOfInt = new List<int>{
                1,2,3,4,5,6,7,8,9,0};

            var smallerNumbers = from num in listOfInt
                                 //orderby num
                                 where num < 8
                                 select num;

            foreach (int number in smallerNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\n----------\n");

            var smallerNumbers2 = listOfInt.Where(n => n < 8).Select(n => n);

            foreach (int number in smallerNumbers2)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\n----------\n");

            var methods = from method in typeof(int).GetMethods()
                          orderby method.Name
                          group method by method.Name into groups
                          select new
                          {
                              MethodName = groups.Key,
                              MethodOverloads = groups.Count()
                          };

            foreach (var item in methods)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n----------\n");

            var million = Enumerable.Range(0, 1000000).Select(x => { 
                Thread.Sleep(500); 
                return x * x; 
            });

            foreach (var number in million)
            {
                Console.Write(number + " ");
            }
        }
    }
}
