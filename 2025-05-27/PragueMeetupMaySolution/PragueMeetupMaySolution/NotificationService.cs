namespace PragueMeetupMaySolution;

internal class NotificationService
{
    private readonly List<string> _notifications = new();

    public Action<IReadOnlyList<string>>? BatchSend;

    internal void Add(string notification)
        => _notifications.Add(notification);

    internal void ReadyToBatchSend()
    {
        BatchSend?.Invoke(_notifications.AsReadOnly());
        _notifications.Clear();
    }
}
