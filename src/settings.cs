using System;
using System.IO;

namespace ROCKET{
    class settings{
        public static void main(string args){
            if (args == "startupLogs"){
                decoyStartup();
            }
        }
        public static void decoyStartup(){
            string toggle = System.IO.File.ReadAllText(@"C:\rocket\configs\startup\decoy");
            if(toggle == "1"){
                System.IO.File.WriteAllText(@"C:\rocket\configs\startup\decoy", "0");
            }
            else if(toggle == "0"){
                System.IO.File.WriteAllText(@"C:\rocket\configs\startup\decoy", "1");
            }
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.BackgroundColor = ConsoleColor.DarkBlue;

                //cool thing
                //Console.WriteLine(" LOG                                           ");
                //Thread.Sleep(100);
                //Console.WriteLine("║Starting up . . .");
                //Thread.Sleep(100);
                //Console.WriteLine(@"║C:\ROCKET\configs\startup\cd = string.Empty  ");
                //Thread.Sleep(100);
                //Console.WriteLine("║OutputEncoding = System.Text.Encoding.Unicode");
                //Console.ForegroundColor = ConsoleColor.White;
                //Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}