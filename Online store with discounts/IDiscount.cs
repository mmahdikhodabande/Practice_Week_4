using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_store_with_discounts
{
    public interface IDiscount
    {
        double ApplyDiscount(double price);
    }
}
