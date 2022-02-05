using System;
using System.IO;
using System.Diagnostics;
using System.Linq;

namespace ROCKET{
    class dir{
        public static void directory(string path){
            if(path == ""){
                path = Directory.GetCurrentDirectory();
            }
            string[] files = Directory.GetFiles(path);
            string[] folders = Directory.GetDirectories(path);
            Console.WriteLine("\n Directory of "+path+"\n");

            foreach(var folder in folders){
                string folder1 = folder;
                folder1 = folder1.Replace(path+"\\","");
                Console.WriteLine("[+]"+folder1);
            }
            foreach(var file in files){
                FileInfo fi = new FileInfo(file); 
                DateTime creationTime = fi.CreationTime;
                long size = fi.Length; 
                string[] sizes = { "B", "KB", "MB", "GB", "TB" };
                double len = new FileInfo(file).Length;
                int order = 0;
                while (len >= 1024 && order < sizes.Length - 1) {
                    order++;
                    len = len/1024;
                }
                string result = String.Format("{0:0.##} {1}", len, sizes[order]);
                string file1 = file;
                file1 = file1.Replace(path+"\\","");
                Console.WriteLine("   "+file1+"   |   "+result+"   |   "+creationTime);
                //Console.WriteLine("   "+file1+"   "+creationTime);
            }
            Console.WriteLine();
        }
        public static int RenameFile(string path, string newName)
        {
            FileInfo file = new FileInfo(path);
            DirectoryInfo directory = new DirectoryInfo(path);
            if (!file.Exists && !directory.Exists)
            {
                return -1;
            }
            if (file.Exists)
            {
                file.MoveTo(file.DirectoryName + @"\" + newName);
                Console.WriteLine("File Renamed.");
            }
            else if (directory.Exists)
            {
                directory.MoveTo(directory.Parent.FullName + @"\" + newName);
                Console.WriteLine("Folder Renamed.");
            }
            return 0;
        }

        public static void LaunchFile(string path)
        {
        FileInfo file = new FileInfo(path);
        new Process { StartInfo = new ProcessStartInfo(path) { UseShellExecute = true } }.Start();
        }

        public static void cd(string path)
        {
            System.IO.File.WriteAllText(@"C:\rocket\configs\startup\cd",path);
        }
    }
}