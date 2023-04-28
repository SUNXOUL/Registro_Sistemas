using Radzen;
public static class Extension
{
    public static void ShowNotification(this NotificationService notifier, string summary, string detail, NotificationSeverity severity)
    {
        var message = new NotificationMessage
        {
            Severity = severity,
            Summary = summary,
            Detail = detail,
            Duration = 3000
        };

        notifier.Notify(message);
    }

}