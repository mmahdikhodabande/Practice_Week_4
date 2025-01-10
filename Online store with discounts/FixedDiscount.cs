using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_store_with_discounts
{
    public class FixedDiscount : IDiscount
    {
        private double _amount;

        public FixedDiscount(double amount)
        {
            _amount = amount;
        }

        public double ApplyDiscount(double price)
        {
            return price - _amount;
        }
    }
}
