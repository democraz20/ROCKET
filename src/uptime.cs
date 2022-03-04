using System;

namespace ROCKET{
    class uptime{
        public static TimeSpan GetSystemUpTime()
	    {
		    return TimeSpan.FromMilliseconds(Environment.TickCount);
	    }
        public static void sysuptime(){
            TimeSpan time = GetSystemUpTime();

            Console.WriteLine($"System time up: " +
            	$"{time.Days} days " +
            	$"{time.Hours} hours " +
            	$"{time.Minutes} minutes " +
            	$"{time.Seconds} seconds");
        }
    }
}