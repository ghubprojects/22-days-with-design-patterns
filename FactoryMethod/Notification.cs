namespace FactoryMethod;

public interface INotification {
    void NotifyUser(string message);
}

public class SMSNotification : INotification {
    public void NotifyUser(string message) => Console.WriteLine($"SMS Notification: {message}");
}

public class EmailNotification : INotification {
    public void NotifyUser(string message) => Console.WriteLine($"Email Notification: {message}");
}

public class PushNotification : INotification {
    public void NotifyUser(string message) => Console.WriteLine($"Push Notification: {message}");
}