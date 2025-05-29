namespace PragueMeetupMaySolution;

[TestClass]
public class DiscountServiceTests
{
    [TestMethod]
    [DataRow("regular", 100, 90)]
    [DataRow("vip", 100, 85)]
    [DataRow("regular", 100, 90)]
    [DataRow("vip", 200, 170)]
    public void CalculateDiscountedPrice_ShouldReturnExpectedAmount(string customerType, decimal originalPrice, decimal expectedPrice)
    {
        var service = new DiscountService();
        var result = service.CalculateDiscountedPrice(customerType, originalPrice);
        Assert.AreEqual(expectedPrice, result);
    }
}
