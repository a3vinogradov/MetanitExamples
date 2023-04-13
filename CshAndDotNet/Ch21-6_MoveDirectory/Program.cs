using System;
using System.IO;

namespace Ch16_6_MoveDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            string oldPath = @"C:\SomeFolder";
            string newPath = @"C:\SomeDir";
            DirectoryInfo dirInfo = new DirectoryInfo(oldPath);
            if (dirInfo.Exists && Directory.Exists(newPath) == false)
            {
                dirInfo.MoveTo(newPath);
            }

        }
    }
}
