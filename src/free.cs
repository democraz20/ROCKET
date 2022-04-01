using System;

namespace ROCKET{
    class memory{
        public static void free (){
            Console.WriteLine("Memory used before collection: {0:N0}",GC.GetTotalMemory(false));
            GC.Collect();
            Console.WriteLine("Memory used after full collection: {0:N0}",GC.GetTotalMemory(true));
        }
        
    }
}