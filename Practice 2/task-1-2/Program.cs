using System;
using System.IO;

namespace task_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileSystemWatcher watcher = new FileSystemWatcher(@"C:\temp");
            watcher.Filter = "*.*";
            watcher.IncludeSubdirectories = true;
            
            watcher.Changed += new FileSystemEventHandler(watcherChanged);
            watcher.Created += new FileSystemEventHandler(watcherChanged);
            watcher.Deleted += new FileSystemEventHandler(watcherChanged);
            watcher.Renamed += new RenamedEventHandler(watcherRenamed);

            watcher.EnableRaisingEvents = true;
            Console.Read();
        }

        static void watcherChanged(object sender, FileSystemEventArgs e) =>
            Console.WriteLine($"Changed: {e.FullPath}");

        static void watcherRenamed(object sender, RenamedEventArgs e) =>
            Console.WriteLine($"Renamed from {e.OldFullPath} to {e.FullPath}");
    }
}
