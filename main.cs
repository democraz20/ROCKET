using System;
using System.IO;
using System.Diagnostics;
using System.Linq;

namespace ROCKET{
    class main{
        public static void center(){
            Console.WriteLine(DateTime.Now.ToString("h:mm:ss"));
            string uptimestart = DateTime.Now.ToString("h mm ss");
            //Console.WriteLine(uptimestart);
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
                    switch(input){
                        case "dir":
                            input="dir ";
                            break;
                        case "open":
                            input="open ";
                            break;
                        case "rename":
                            input="rename  ";
                            break;
                        case "cd":
                            input="cd ";
                            break;
                    }

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
                    else if (cmd[0] == "uptime"){
                        uptime.sysuptime();
                    }
                    else if (cmd[0] == "update"){
                        updates.minor();
                    }
                    else if (cmd[0] == "free"){
                        memory.free();
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