
namespace HelloWorldTests;

[TestClass]
public sealed class TestClass1
{
    [TestMethod]
    public void TestMethod1()
    {
        Assert.AreEqual(
            expected: "Hello, .NET Meetup 2025!", 
            actual:   "Hello, .NET Meetup 2025!"
            );
    }
}
