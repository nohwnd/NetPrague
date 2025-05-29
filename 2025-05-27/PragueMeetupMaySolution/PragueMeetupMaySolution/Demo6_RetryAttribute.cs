namespace PragueMeetupMaySolution;

[TestClass]
public class TestClass6
{
    private static int _currentRun;

    [TestMethod]
    [Retry(2)]
    public void TestMethod1()
    {
        const int NumberOfFailures = 2;
        _currentRun++;
        if (_currentRun <= NumberOfFailures)
            Assert.Fail("This should fail");
    }
}
