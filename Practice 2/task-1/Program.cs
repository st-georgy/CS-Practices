using System;
using System.IO;

namespace task_1
{
    class Program
    {
        static void Main(string[] args) {
            int accessDenied = 0;
            ShowDirectory(new DirectoryInfo(Environment.SystemDirectory), ref accessDenied);
            Console.WriteLine($"Access denied folders: {accessDenied}");
            Console.ReadKey();
        }

        static void ShowDirectory(DirectoryInfo dir, ref int accessDenied) {
            foreach (FileInfo file in dir.GetFiles())
            {
                try { Console.WriteLine($"File: {file.FullName}"); }
                catch (Exception ex) { Console.WriteLine(ex.Message);  continue; }
            }
            foreach (DirectoryInfo subDir in dir.GetDirectories())
            {
                try { ShowDirectory(subDir, ref accessDenied); }
                catch (UnauthorizedAccessException ex) { accessDenied++; continue; }
            }
        }
    }
}
