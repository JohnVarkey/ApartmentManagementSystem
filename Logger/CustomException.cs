using System.ComponentModel;

namespace CustomException
{
    public interface IException
    {
        string Type { get; }

        public string GetExceptionInfo();
    }


    public class CustomError : Exception, IException
    {
        string IException.Type { get; } = "Error";
        private string message;
        public CustomError(string message) : base(message)
        {
            this.message = message;
        }

        public string GetExceptionInfo()
        {
            return $"Error: {DateTime.Now}: {message}";
        }
    }

    public class CustomWarning : WarningException, IException
    {
        string IException.Type { get; } = "Warning";
        private string message;
        public CustomWarning(string message) : base(message)
        {
            this.message = message;
        }

        public string GetExceptionInfo()
        {
            return $"Warning: {DateTime.Now}: {message}";
        }
    }

    public class CustomInfo : IException
    {
        string IException.Type { get; } = "Info";
        private string message;
        public CustomInfo(string message)
        {
            this.message = message;
        }

        public string GetExceptionInfo()
        {
            return $"Info: {DateTime.Now}: {message}";
        }
    }

    class NotImplementationError : CustomError
    {
        public NotImplementationError() : base("Not Implemented Custom")
        {
        }
    }


}

