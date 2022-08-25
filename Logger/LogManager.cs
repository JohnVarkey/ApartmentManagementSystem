using System;
using System.IO;
using CustomException;

namespace Logger
{
    public interface ILogger
    {
        public void Log(IException exception);
    }


    class ConsoleLogger : ILogger
    {
        public void Log(IException exception)
        {
            Console.WriteLine(exception.GetExceptionInfo());
        }
    }

    class FileLogger : ILogger { 

        string path;
        public FileLogger(string stream)
        {
            path = stream;
        }
        
        public void Log(IException exception)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine($"{exception.GetExceptionInfo()}");

            }
        }
    }




    public static class LogManager
    {
        public static int Level { get; set; }
        private static List<ILogger> LoggerList = new List<ILogger>();


        public static void AddLogger(ILogger logger)
        {
            LoggerList.Add(logger);
        }
        public static void Log(IException exception)
        {
            if (LoggerList.Count == 0)
            {
                Console.WriteLine("No Logger Configured");
                return;
            }
            foreach (ILogger logger in LoggerList) logger.Log(exception);

        }
    }

}
