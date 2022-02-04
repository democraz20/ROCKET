using System;
using System.IO;

namespace ROCKET{
    class dir{
        public static void directory(string path){
            if(path == ""){
                path = Directory.GetCurrentDirectory();
            }
            string[] files = Directory.GetFiles(path);
            string[] folders = Directory.GetDirectories(path);

            foreach(var folder in folders){
                string folder1 = folder;
                folder1 = folder1.Replace(path,"");
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
                file1 = file1.Replace(path,"");
                Console.WriteLine("   "+file1+"     "+result);
                //Console.WriteLine("   "+file1+"   "+creationTime);
            }
        }
    }
}