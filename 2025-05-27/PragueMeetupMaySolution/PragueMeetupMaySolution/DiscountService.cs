
namespace PragueMeetupMaySolution;

internal class DiscountService
{
    public DiscountService()
    {
    }

    internal decimal CalculateDiscountedPrice(string customerType, decimal originalPrice)
    {
        return customerType switch
        {
            "regular" => originalPrice * 0.9m,
            "vip" => originalPrice * 0.85m,
            _ => throw new ArgumentException()
        };
    }
}