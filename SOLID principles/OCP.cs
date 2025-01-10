using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principles
{
    internal class OCP
    {
        #region Wrong code
        public class TaxCalculator
        {
            public double CalculateTax(string country, double amount)
            {
                if (country == "USA")
                {
                    return amount * 0.1; 
                }
                else if (country == "Germany")
                {
                    return amount * 0.2; 
                }
                else if (country == "UK")
                {
                    return amount * 0.15; 
                }
                else
                {
                    return 0; 
                }
            }
        }
        #endregion

        #region Correct code
       
        public interface ITaxStrategy
        {
            double CalculateTax(double amount);
        }

       
        public class USATax : ITaxStrategy
        {
            public double CalculateTax(double amount)
            {
                return amount * 0.1;
            }
        }

        
        public class GermanyTax : ITaxStrategy
        {
            public double CalculateTax(double amount)
            {
                return amount * 0.2;
            }
        }

       
        public class UKTax : ITaxStrategy
        {
            public double CalculateTax(double amount)
            {
                return amount * 0.15;
            }
        }

       
        public class TaxCalculatoR
        {
            private readonly ITaxStrategy _taxStrategy;

            public TaxCalculatoR(ITaxStrategy taxStrategy)
            {
                _taxStrategy = taxStrategy;
            }

            public double Calculate(double amount)
            {
                return _taxStrategy.CalculateTax(amount);
            }
        }

        #endregion
    }
}
