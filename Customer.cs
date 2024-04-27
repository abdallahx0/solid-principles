namespace SOLID;

public class Customer : IUserManagement, ISubscriptionNotificationService
{
    public string Name { get; } = "Customer Name";
    public string Email { get; } = "email@example.com";

    public void SubscribeToNewProductsAvailability()
    {
        Console.WriteLine("Subscribing to new products availability...");
    }

    public void SubscribeToSMSNotifications()
    {
        Console.WriteLine("Subscribing to new products availability...");
    }

    public void UpdateUserProfile(Customer customer)
    {
        Console.WriteLine($"Updating user profile {customer.Name}...");
    }

    public void ChangePassword(Customer customer, string password)
    {
        Console.WriteLine($"Updating user: {customer.Name}...");
    }
}
