using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    public class DigitalClock
    {
        public void Subscribe(Clock theClock)
        {
            theClock.SecondChanged += NewTime;
        }

        public void NewTime(object o, TimeInfoEventArgs timeInfoEventArgs)
        {
            Console.WriteLine("Current Time: " + timeInfoEventArgs.Hour + ":" + timeInfoEventArgs.Minute + ":" + timeInfoEventArgs.Second);
        }
    }
}
