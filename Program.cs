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
                //check if OS is windows
                if (Environment.OSVersion.ToString().Contains("Windows")){
                    System.IO.File.WriteAllText(@"C:\ROCKET\configs\startup\cd", string.Empty);
                    Console.OutputEncoding = System.Text.Encoding.Unicode;
                

                    //actual start
                    Console.WriteLine("Hello World!");
                    main.center();
                }
                else{
                    Console.Write("This program is only compatible with Windows. \n press any key to exit.");
                    Console.ReadLine();
                }
                //startup

            }
            catch(Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
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
