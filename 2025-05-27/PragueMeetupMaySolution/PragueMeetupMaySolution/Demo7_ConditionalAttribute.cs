namespace PragueMeetupMaySolution;

[TestClass]
public class TestClass7
{
    // NOTE: Comments assume that current machine is Windows.

    [TestMethod]
    [OSCondition(ConditionMode.Include, OperatingSystems.Windows)]
    public void RunsOnWindowsOnly() // Runs
    {
    }

    [TestMethod]
    [OSCondition(ConditionMode.Include, OperatingSystems.Linux)]
    public void RunsOnLinuxOnly() // Skipped
    {
    }

    [TestMethod]
    [OSCondition(ConditionMode.Exclude, OperatingSystems.Windows)]
    public void RunsEverywhereExceptOnWindows() // Skipped
    {
    }

    [TestMethod]
    [OSCondition(ConditionMode.Exclude, OperatingSystems.Linux)]
    public void RunsEverywhereExceptOnLinux() // Runs
    {
    }
}
