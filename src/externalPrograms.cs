using System;
using System.IO;
using System.Diagnostics;

namespace ROCKET{
    class open {
        public static void Windows(string Programs)  
        {
            switch(Programs){
                case "notepad":
                    Programs = @"C:\windows\notepad.exe";
                    break;
                case "file":
                    Programs = @"C:\windows\explorer.exe";
                    break;
                case "rtf":
                    Programs = @"C:\windows\write.exe";
                    break;
                case "cmd":
                    Programs = @"C:\windows\system32\cmd.exe";
                    break;
                case "py":
                    Programs = @"C:\python\py.exe";
                    break;
                case "calc":
                    Programs = @"C:\windows\system32\calc.exe";
                    break;
                case "powershell":
                    Programs = @"C:\windows\system32\WindowsPowerShell\v1.0\powershell.exe";
                    break;
                case "winver":
                    Programs = @"C:\windows\system32\winver.exe";
                    break;
            }
            //check if file exists
            if(File.Exists(Programs)){
                FileInfo file = new FileInfo(Programs);
                new Process { StartInfo = new ProcessStartInfo(Programs) { UseShellExecute = true } }.Start();
            }
            else{
                Console.WriteLine("File not found");
            }
        }
    }
}