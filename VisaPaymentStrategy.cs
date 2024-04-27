namespace SOLID;

public class VisaIPaymentStrategy : IPaymentStrategy
{

    public void ProcessPayment(double amount)
    {
        Console.WriteLine("Processing visa card payments...");
    }
}
