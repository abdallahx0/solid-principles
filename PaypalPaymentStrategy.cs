namespace SOLID;

public class PaypalIPaymentStrategy : IPaymentStrategy {

    public void ProcessPayment(double amount) {
        Console.WriteLine("Processing paypal payments...");
    }
}
