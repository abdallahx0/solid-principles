namespace SOLID;

public class MasterCardIPaymentStrategy : IPaymentStrategy {

    public void ProcessPayment(double amount) {
        Console.WriteLine("Processing master card payments...");
    }
}
