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
                
            }
            FileInfo file = new FileInfo(Programs);
            new Process { StartInfo = new ProcessStartInfo(Programs) { UseShellExecute = true } }.Start();
        }
    }
}