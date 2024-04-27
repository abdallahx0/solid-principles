namespace SOLID;
internal class Program
{
    static void Main(string[] args)
    {
        var visaCard = new PaymentProcessor(new VisaIPaymentStrategy());
        visaCard.ProcessPayment(new Order());

        var paypal = new PaymentProcessor(new PaypalIPaymentStrategy());
        paypal.ProcessPayment(new Order());

        var masterCard = new PaymentProcessor(new MasterCardIPaymentStrategy());
        masterCard.ProcessPayment(new Order());
    }
}

