using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpressionsDemo
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            int a = 10;
            int b = 20;

            Func<int, int, int> multiplyDelegate;
            multiplyDelegate = Multiply;
            int product = multiplyDelegate(a, b);
            Console.WriteLine(product);

            Func<int, int, int> multiplyDelegate2 = (x, y) => (x * y);
            int product2 = multiplyDelegate2(a, b);
            Console.WriteLine(product2);
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
