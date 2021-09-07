using System;

namespace HomeWork
{
    public class Starter
    {
        private int _countCycles = 100;
        private int _countMethods = 3;

        public void Run()
        {
            Random random = new Random();
            Actions actions = new Actions();

            for (int i = 0; i < _countCycles; i++)
            {
                int nextMethodIndex = random.Next(_countMethods);
                Result result;

                switch (nextMethodIndex)
                {
                    case 0:
                        result = actions.MethodOne();
                        break;
                    case 1:
                        result = actions.MethodTwo();
                        break;
                    case 2:
                        result = actions.MethodBob();
                        break;
                    default:
                        return;
                }

                if (!result.Status)
                {
                    Logger.WriteToLog(
                        $"Action failed by a reason: {result.Message}",
                        Logger.TypeError);
                }
            }

            Logger.SaveToFile();
        }
    }
}