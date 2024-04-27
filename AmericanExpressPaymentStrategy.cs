namespace SOLID;

public class AmericanExpressIPaymentStrategy : IPaymentStrategy
{

    public void ProcessPayment(double amount)
    {
        Console.WriteLine("Processing american express card payments...");
    }
}
