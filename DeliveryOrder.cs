namespace SOLID;

public class DeliveryOrder : Order, IShippingCostCalculator
{
    private const double SHIPPING_COST = 10.0;

    public double CalculateShippingCost()
    {
        return Price + SHIPPING_COST;
    }
}
