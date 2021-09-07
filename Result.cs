namespace HomeWork
{
    public class Result
    {
        private bool _status;
        private string _message;

        public Result(bool status)
        {
            _status = status;
        }

        public Result(bool status, string message)
        {
            _status = status;
            _message = message;
        }

        public bool Status => _status;
        public string Message => _message;
    }
}