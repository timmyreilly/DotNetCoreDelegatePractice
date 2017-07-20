using System;
using System.Threading;
using System.Runtime.InteropServices.ComTypes;
using System.IO;
 


namespace DelegatePractice
{
    public enum Severity
    {
        Verbose,
        Trace,
        Information,
        Warning,
        Error,
        Critical
    }
    public static class Logger
    {
        public static Action<string> WriteMessage;

        public static Severity LogLevel { get; set; } = Severity.Warning;

        public static void LogMessage(Severity s, string component, string msg)
        {
            if (s < LogLevel)
            {
                return;
            }

            var outputMsg = $"{DateTime.Now}\t{s}\t{component}\t{msg}";
            WriteMessage(outputMsg);
        }

        public static void LogMessage(string msg)
        {
            WriteMessage(msg);
        }
    }

    public class FileFoundArgs : EventArgs
    {
        public string FoundFile { get; }
        public bool CancelRequested { get; set; }

        public FileFoundArgs(string fileName)
        {
            FoundFile = fileName;
        }

    }

    public class FileSearcher
    {
        public event EventHandler<FileFoundArgs> FileFound;

        public void Search(string directory, string searchPattern)
        {
            foreach (var file in Directory.EnumerateFiles(directory, searchPattern))
            {
                FileFound?.Invoke(this, new FileFoundArgs(file));
            }
        }

        public void List(string directory, string searchPattern)
        {
            foreach (var file in Directory.EnumerateFiles(directory, searchPattern))
            {
                var args = new FileFoundArgs(file);
                FileFound?.Invoke(this, args);
                if (args.CancelRequested)
                    break;
            }
        }
    }

    class MyClass
    {
        // public delegate void SecondDelegate(char a, char b); 
        static void Main(string[] args)
        {
            EventHandler<FileFoundArgs> onFileFound = (sender, EventArgs) =>
            {
                Console.WriteLine(EventArgs.FoundFile);
                EventArgs.CancelRequested = true;
            };
        }

    }
}



