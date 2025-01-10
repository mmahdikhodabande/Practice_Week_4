using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principles
{
    internal class ISP
    {
        #region Wrong code
        public interface IMachine
        {
            void Print(string content);
            void Scan(string content);
            void Fax(string content);
        }

        public class Printer : IMachine
        {
            public void Print(string content)
            {
                Console.WriteLine($"Printing: {content}");
            }

            public void Scan(string content)
            {
                throw new NotImplementedException();
            }

            public void Fax(string content)
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region Correct code
        
        public interface IPrinter
        {
            void Print(string content);
        }

        public interface IScanner
        {
            void Scan(string content);
        }

        public interface IFax
        {
            void Fax(string content);
        }

        
        public class Printer : IPrinter
        {
            public void Print(string content)
            {
                Console.WriteLine($"Printing: {content}");
            }
        }

        public class Scanner : IScanner
        {
            public void Scan(string content)
            {
                Console.WriteLine($"Scanning: {content}");
            }
        }

        public class FaxMachine : IFax
        {
            public void Fax(string content)
            {
                Console.WriteLine($"Faxing: {content}");
            }
        }

        #endregion
    }
}
