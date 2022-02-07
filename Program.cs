using System;
using System.IO;
using System.Threading;

namespace ROCKET
{
    class Program
    {
        static void Main(string[] args)
        {
            for(;;){
            try{
                //startup
                System.IO.File.WriteAllText(@"C:\ROCKET\configs\startup\cd", string.Empty);
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkBlue;

                //cool thing
                Console.WriteLine(" LOG                                           ");
                Thread.Sleep(500);
                Console.WriteLine("╔=============================================╗");
                Console.WriteLine("║Starting up . . .                            ║");
                Thread.Sleep(500);
                Console.WriteLine(@"║C:\ROCKET\configs\startup\cd = string.Empty  ║");
                Thread.Sleep(500);
                Console.WriteLine("║OutputEncoding = System.Text.Encoding.Unicode║");
                Console.WriteLine("╚=============================================╝");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;

                //actual start
                Console.WriteLine("Hello World!");
                main.center();
            }
            catch(Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message+"\n");
                Console.WriteLine("BSOD type error");
                Console.ForegroundColor = ConsoleColor.White;
            }
            finally{
            }
            }
        }
    }
}
