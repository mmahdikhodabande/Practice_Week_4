using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principles
{
    internal class DIP
    {
        #region Wrong code
        public class FileLogger
        {
            public void Log(string message)
            {
                Console.WriteLine($"Log to file: {message}");
            }
        }

        public class OrderProcessor
        {
            private FileLogger _logger;

            public OrderProcessor()
            {
                _logger = new FileLogger();
            }

            public void ProcessOrder()
            {
                _logger.Log("Processing order...");
                
            }
        }


        #endregion
        #region Correct code
        
        public interface ILogger
        {
            void Log(string message);
        }

       
        public class FileLogger : ILogger
        {
            public void Log(string message)
            {
                Console.WriteLine($"Log to file: {message}");
            }
        }

        public class DatabaseLogger : ILogger
        {
            public void Log(string message)
            {
                Console.WriteLine($"Log to database: {message}");
            }
        }

        
        public class OrderProcessor
        {
            private readonly ILogger _logger;

            public OrderProcessor(ILogger logger)
            {
                _logger = logger;
            }

            public void ProcessOrder()
            {
                _logger.Log("Processing order...");
                
            }
        }

        #endregion
    }
}
