using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace SkyDiver_GCS
{
    public static class MultiThread
    {
        //Experimental
        /*static float x = 99.7f;
        static float y = 12.3f;
        static float z = 60.3f;*/
        public static Thread RealtimeProcess = new Thread(Thread1)
        {
            Name = "Realtime Process",
            Priority = ThreadPriority.Lowest
        };
        public static Thread tfCam = new Thread(Thread2)
        {
            Name = "fpsCam",
            Priority = ThreadPriority.Lowest
        };
        static void Thread1()
        {
            Console.WriteLine("Thread1 Started using " + Thread.CurrentThread.Name);

            while (true)
            {
                MassageAndCommandVar.massageReceived += "a";

                /*x -= 0.1f;
                y -= 0.1f;
                z -= 0.1f;

                BatteryVar.StateOfCharge = x;
                BatteryVar.Voltage = y;
                BatteryVar.Ampere = z;*/
                Thread.Sleep(100);
            }
        }

        static void Thread2()
        {
            Console.WriteLine("Thread2 Started using " + Thread.CurrentThread.Name);
            while (true)
            {

            }
        }
    }
}
