namespace PragueMeetupMaySolution;

[TestClass]
public class InvoiceServiceTests
{
    [TestMethod]
    public void GenerateInvoiceNumber_ShouldReturnUniqueValues()
    {
        var service = new InvoiceService();

        int invoiceNumber1 = service.GenerateInvoiceNumber();
        int invoiceNumber2 = service.GenerateInvoiceNumber();

        Assert.AreNotSame(invoiceNumber1, invoiceNumber2);
    }
}
