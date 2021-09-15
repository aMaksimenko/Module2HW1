using System;
using System.IO;

namespace HomeWork
{
    public class Starter
    {
        private const int CountCycles = 100;
        private const int CountMethods = 3;
        private readonly Random _random = new Random();
        private readonly Actions _actions = new Actions();

        public void Run()
        {
            for (var i = 0; i < CountCycles; i++)
            {
                var nextMethodIndex = _random.Next(CountMethods);
                Result result = null;

                switch (nextMethodIndex)
                {
                    case 0:
                        result = _actions.MethodOne();
                        break;
                    case 1:
                        result = _actions.MethodTwo();
                        break;
                    case 2:
                        result = _actions.MethodBob();
                        break;
                }

                if (result != null && !result.Status)
                {
                    Logger.Instance.Write($"Action failed by a reason: {result.Message}", LoggerType.Error);
                }
            }

            File.WriteAllText("log.txt", Logger.Instance.Log);
        }
    }
}