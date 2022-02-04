using System;

namespace ROCKET
{
    class Program
    {
        static void Main(string[] args)
        {
            for(;;){
            try{
                Console.WriteLine("Hello World!");
                main.center();
            }
            catch(Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message+"\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            finally{
            }
            }
        }
    }
}
