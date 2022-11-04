using System;
using System.Collections.Generic;
using System.Text;

namespace DemoExample2
{
    public class StopWatch
    {
        DateTime dateTime = DateTime.Now;
        public void start()
        {
            int startHr = dateTime.Hour;
            int startMin = dateTime.Minute;
            int startSec = dateTime.Second;
            int StartMillisec = dateTime.Millisecond;
            Console.WriteLine("Wait and press x for exit");
            string data = Console.ReadLine().ToLower();
            if (data.Equals("x"))
            {
                DateTime dateTime2 = DateTime.Now;
                int stopHr = dateTime2.Hour;
                int stopMin = dateTime2.Minute;
                int stopSec = dateTime2.Second;
                int StopMillisec = dateTime2.Millisecond;
                Console.WriteLine("Stopwatch details:-Hours:" + (stopHr-startHr)+"\n"
                    +"Minutes:" + (stopMin-startMin) + "\n" + "Seconds:"+(stopSec-startSec) + "\n" +
                    "Milliseconds"+(StopMillisec-StartMillisec));
            }
        }
    }
}
