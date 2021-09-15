using System;
using System.Text;

namespace HomeWork
{
    public class Logger
    {
        private static readonly Logger InstanceValue = new Logger();
        private readonly StringBuilder _stringBuilder = new StringBuilder();

        static Logger()
        {
        }

        private Logger()
        {
        }

        public static Logger Instance => InstanceValue;
        public string Log => _stringBuilder.ToString();

        public void Write(string message, LoggerType type)
        {
            var result = $"{DateTime.UtcNow}: {type}: {message}";

            Console.WriteLine(result);
            _stringBuilder.AppendLine(result);
        }
    }
}