using System.IO;

namespace InterfaceExtensibility
{
        public class FileLogger : ILogger
        {
            private readonly string _path;

            public FileLogger(string path)
            {
                _path = path;
            }

            public void LogError(string message)
            {
                // if something goes wrong, the compiler will make sure to dispose if exception is thrown. using statement will do this
                Log(message, "ERROR");
 
            }

            public void LogInfo(string message)
            {

            }

            private void Log(string message, string messageType)
            {
                Log(message, "INFO");
            }
    }
}
