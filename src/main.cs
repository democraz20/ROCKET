using System;
using System.IO;

namespace ROCKET{
    class main{
        public static void center(){
            for(;;){
                Console.Write(Directory.GetCurrentDirectory() + ">");
                string input = Console.ReadLine().ToLower();
                //debugging params
                if (input == "dir"){input = "dir ";}
                string[] cmd = input.Split(" ");
                if (cmd[0] == "clear"){Console.Clear();}
                else if (cmd[0] == ""){}
                else if (cmd[0] == "dir"){
                    if (cmd[1] == ""){Console.WriteLine("yey");}
                }
                else {
                    //checks if packages dir exists
                    //if yes execute path in file
                    //if not do 
                    // ||
                    // \/

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\""+cmd[0]+"\" is not recognized as an internal or external command\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                //some tests
            }
        }
    }
}