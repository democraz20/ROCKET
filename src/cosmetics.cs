using System;
using System.IO;

namespace ROCKET{
    class cosmetics{
        public static void startup(){
            //will run only once
            string decoyStartup = System.IO.File.ReadAllText(@"c:\rocket\configs\startup\decoy");
            if(decoyStartup == "1"){
                //..
            }
            //else{}
        }
    }
}