using Online_store_with_discounts;

class Program
{
    static void Main(string[] args)
    {
       
        IDiscount percentageDiscount = new PercentageDiscount(10); 
        IEmailService emailService = new EmailService();

        
        Purchase purchase = new Purchase(percentageDiscount, emailService);
        purchase.CompletePurchase("customer@example.com", 1000); 
    }
}
