using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EventsDemo
{
    public class Clock
    {
        private int hour;
        private int minute;
        private int second;

        public delegate void SecondChangedHandler(object Clock, TimeInfoEventArgs timeInfo);

        public event SecondChangedHandler SecondChanged;

        public void run()
        {
            for (; ; )
            {
                Thread.Sleep(100);
                DateTime now = DateTime.Now;
                if (now.Second != second)
                {
                    TimeInfoEventArgs timeInfoEvenArgs = new TimeInfoEventArgs(now.Hour, now.Minute, now.Second);

                    if (SecondChanged != null)
                    { 
                        SecondChanged(this, timeInfoEvenArgs);
                    }
                }
            }
        }
    }
}
