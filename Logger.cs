using System;
using System.IO;
using System.Text;

namespace HomeWork
{
    public class Logger
    {
        private static Logger _instance = new Logger();
        private static StringBuilder _stringBuilder = new StringBuilder();
        private static string _typeError = "Error";
        private static string _typeInfo = "Info";
        private static string _typeWarning = "Warning";

        static Logger()
        {
        }

        private Logger()
        {
        }

        public static Logger Instance => _instance;
        public static string TypeError => _typeError;
        public static string TypeInfo => _typeInfo;
        public static string TypeWarning => _typeWarning;

        public static void WriteToLog(string message, string type)
        {
            string result = $"{DateTime.Now}: {type}: {message}";

            Console.WriteLine(result);
            _stringBuilder.AppendLine(result);
        }

        public static void SaveToFile()
        {
            string dateTimeString = DateTime.Now.ToString("yyyy'-'MM'-'dd'-'HH'-'mm'-'ss");

            File.WriteAllText(
                $"../../../log-{dateTimeString}.txt",
                _stringBuilder.ToString());
        }
    }
}