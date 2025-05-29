namespace PragueMeetupMaySolution;

[TestClass]
public class NotificationServiceTests
{
    [TestMethod]
    public void WhenBatchSendToEmailShouldBeReceivedCorrectly()
    {
        var service = new NotificationService();
        
        service.BatchSend += async notifications =>
        {
            Assert.AreEqual(1, notifications.Count);
            Assert.AreEqual("MyOnlyNotification", notifications[0]);
            await SendToEmailAsync(notifications);
            var receivedNotifications = await GetEmailReceivedAsync();
            Assert.AreEqual(1, receivedNotifications.Count);
            Assert.AreEqual("MyOnlyNotification", receivedNotifications[0]);
        };

        service.Add("MyOnlyNotification");
        service.ReadyToBatchSend();
    }

    private static Task SendToEmailAsync(IReadOnlyList<string> notifications)
    {
        return Task.CompletedTask;
    }

    private static Task<IReadOnlyList<string>> GetEmailReceivedAsync()
    {
        return Task.FromResult<IReadOnlyList<string>>([]);
    }
}
