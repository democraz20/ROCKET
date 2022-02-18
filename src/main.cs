using System;
using System.IO;
using System.Diagnostics;
using System.Linq;

namespace ROCKET{
    class main{
        public static void center(){
            for(;;){
                try{
                    string cd = System.IO.File.ReadAllText(@"c:\rocket\configs\startup\cd");
                    if(cd == string.Empty){
                        Console.Write(Directory.GetCurrentDirectory()+">");
                    }
                    else{
                        Console.Write(System.IO.File.ReadAllText(@"c:\rocket\configs\startup\cd")+">");
                    }
                    //Console.Write(Directory.GetCurrentDirectory() + ">");
                    string input = Console.ReadLine().ToLower();
                    //debugging params
                    if (input == "dir"){input = "dir ";}
                    else if (input == "open"){input = "open ";}
                    else if (input == "rename"){input = "rename  ";}
                    else if (input == "cd"){input = "cd ";}
                    string[] cmd = input.Split(" "); 

                    //main 
                    if (cmd[0] == "cls"){Console.Clear();}
                    else if (cmd[0] == "exit"){Environment.Exit(0);}
                    else if (cmd[0] == ""){}
                    else if (cmd[0] == "dir"){
                        dir.directory(cmd[1]);
                    }
                    else if (cmd[0] == "open"){
                        dir.LaunchFile(cmd[1]);
                    }
                    else if (cmd[0] == "rename"){
                        dir.RenameFile(cmd[1], cmd[2]);
                    }
                    else if (cmd[0] == "cd"){
                        dir.cd(cmd[1]);
                    }
                    else if (cmd[0] == "settings"){
                        settings.main(cmd[1]);
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
                }
                catch (Exception e){
                    main.error(e.Message);
                }
                finally{}
                //some tests
            }
        }
        public static void error(string error){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n"+error+"\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}