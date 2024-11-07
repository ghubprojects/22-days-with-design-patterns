using FactoryMethod;

while (true) {
    Console.Write("Enter the type of notification you want to send (SMS/Email/Push): ");
    var type = (Console.ReadLine() ?? string.Empty).ToLower();

    NotificationFactory factory = type switch {
        "sms" => new SMSNotificationFactory(),
        "email" => new EmailNotificationFactory(),
        "push" => new PushNotificationFactory(),
        _ => throw new Exception("Invalid notification type"),
    };

    var notification = factory.CreateNotification();
    notification.NotifyUser("This is a notification message");

    Console.WriteLine("\n");
    Thread.Sleep(100);
}