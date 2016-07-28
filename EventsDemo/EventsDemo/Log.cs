using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    public class Log
    {
        public void Subscribe(Clock clock)
        {
            clock.SecondChanged += LogTime;
        }

        public void LogTime(object o, TimeInfoEventArgs timeInfoEventArgs)
        {
            Console.WriteLine("Logging " + +timeInfoEventArgs.Hour + ":" + timeInfoEventArgs.Minute + ":" + timeInfoEventArgs.Second);
        }
    }
}
