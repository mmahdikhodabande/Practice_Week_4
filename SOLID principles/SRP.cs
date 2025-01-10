using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principles
{
    internal class SRP
    {
        #region Wrong code
        public void processOrder(int orderId)
        {
            Console.WriteLine($"Processing order with ID: {orderId}");
        }

        public void GenerateReport()
        {
            Console.WriteLine("Generating report...");
        }
        #endregion

        #region Correct code
        public class OrderProcessor
        {
            public void ProcessOrder(int orderId)
            {
                Console.WriteLine($"Processing order with ID: {orderId}");
            }
        }
        public class ReportGenerator
        {
            public void GenerateReport()
            {
                Console.WriteLine("Generating report...");
            }
        }
        #endregion

    }
}
