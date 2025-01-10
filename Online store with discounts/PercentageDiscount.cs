using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_store_with_discounts
{
    public class PercentageDiscount : IDiscount
    {
        private double _percentage;

        public PercentageDiscount(double percentage)
        {
            _percentage = percentage;
        }

        public double ApplyDiscount(double price)
        {
            return price - (price * _percentage / 100);
        }
    }
}
