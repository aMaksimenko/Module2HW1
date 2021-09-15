namespace HomeWork
{
    public class Actions
    {
        public Result MethodOne()
        {
            Logger.Instance.Write($"Start method: {nameof(MethodOne)}", LoggerType.Info);

            return new Result() { Status = true };
        }

        public Result MethodTwo()
        {
            Logger.Instance.Write($"Skipped logic in method: {nameof(MethodTwo)}", LoggerType.Warning);

            return new Result() { Status = true };
        }

        public Result MethodBob()
        {
            return new Result() { Message = "I broke a logic" };
        }
    }
}