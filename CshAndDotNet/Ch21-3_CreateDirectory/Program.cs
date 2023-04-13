using System;
using System.IO;

namespace Ch21_CreateDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\SomeDir";
            string subpath = @"program\avalon";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            dirInfo.CreateSubdirectory(subpath);
        }
    }
}
