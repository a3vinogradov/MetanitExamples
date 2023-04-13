using System;
using System.IO;

namespace Ch21_5_DeleteDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirName = @"C:\SomeDir";

            try
            {
                //Directory.Delete(dirName, true);
                //или так
                DirectoryInfo dirInfo = new DirectoryInfo(dirName);
                dirInfo.Delete(true);

                Console.WriteLine("Каталог удален");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
