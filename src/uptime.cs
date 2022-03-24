using System;

namespace ROCKET{
    class uptime{
        private static TimeSpan GetSystemUpTime()
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
        public static void appuptime(string start){
            string[] usestart = start.Split(" ");
            int strh = Convert.ToInt32(usestart[0]);
            int strm = Convert.ToInt32(usestart[1]);
            int strs = Convert.ToInt32(usestart[2]);
            
            string currenttime = DateTime.Now.ToString("h mm ss");
            int curh = Convert.ToInt32(currenttime[0]);
            int curm = Convert.ToInt32(currenttime[1]);
            int curs = Convert.ToInt32(currenttime[2]);
            string[] usecurre = currenttime.Split(" ");

        }
    }
}