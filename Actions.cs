using System.Reflection;

namespace HomeWork
{
    public class Actions
    {
        public Result MethodOne()
        {
            MethodBase methodBase = MethodBase.GetCurrentMethod();
            Logger.WriteToLog(
                $"Start method: {methodBase?.Name}",
                Logger.TypeInfo);

            return new Result(true);
        }

        public Result MethodTwo()
        {
            MethodBase methodBase = MethodBase.GetCurrentMethod();
            Logger.WriteToLog(
                $"Skipped logic in method: {methodBase?.Name}",
                Logger.TypeWarning);

            return new Result(true);
        }

        public Result MethodBob()
        {
            return new Result(false, "I broke a logic");
        }
    }
}