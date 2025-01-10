using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_store_with_discounts
{
    public class Purchase
    {
        private IDiscount _discount;
        private IEmailService _emailService;

        public Purchase(IDiscount discount, IEmailService emailService)
        {
            _discount = discount;
            _emailService = emailService;
        }

        public void CompletePurchase(string customerEmail, double price)
        {
            double finalPrice = _discount.ApplyDiscount(price);


            Console.WriteLine($"Final price after discount: {finalPrice}");


            _emailService.SendEmail(customerEmail, "Purchase Confirmation", $"Your purchase was successful. Final price: {finalPrice}");
        }
    }
}
