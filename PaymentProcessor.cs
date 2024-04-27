namespace SOLID;

public class PaymentProcessor
{
    private readonly IPaymentStrategy _paymentStrategy;

    public PaymentProcessor(IPaymentStrategy IPaymentStrategy)
    {
        _paymentStrategy = IPaymentStrategy;
    }

    public void ProcessPayment(Order order)
    {
        Console.WriteLine($"Processing payment of order: {order.Name}");
        Console.WriteLine($"Issuing payment for amount: {order.Price}");

        _paymentStrategy.ProcessPayment(order.Price);
    }

}
