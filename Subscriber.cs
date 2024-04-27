namespace SOLID;

public class Subscriber : ISubscriptionNotificationService
{
    public void SubscribeToNewProductsAvailability()
    {
        Console.WriteLine("Subscribing to new products availability...");
    }

    public void SubscribeToSMSNotifications()
    {
        Console.WriteLine("Subscribing to new products availability...");
    }
}
