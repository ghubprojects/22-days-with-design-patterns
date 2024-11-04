namespace FactoryMethod;

public abstract class NotificationFactory {
    public abstract INotification CreateNotification();
}

public class SMSNotificationFactory : NotificationFactory {
    public override INotification CreateNotification() => new SMSNotification();
}

public class EmailNotificationFactory : NotificationFactory {
    public override INotification CreateNotification() => new EmailNotification();
}

public class PushNotificationFactory : NotificationFactory {
    public override INotification CreateNotification() => new PushNotification();
}