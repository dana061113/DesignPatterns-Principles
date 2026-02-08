using System;

public interface IMessageSender
{
    void Send(string message);
}

public class EmailSender : IMessageSender
{
    public void Send(string message)
    {
        Console.WriteLine("Email sent: " + message);
    }
}

public class SmsSender : IMessageSender
{
    public void Send(string message)
    {
        Console.WriteLine("SMS sent: " + message);
    }
}

public class NotificationService
{
    private readonly IMessageSender sender;

    public NotificationService(IMessageSender sender)
    {
        this.sender = sender;
    }

    public void SendNotification(string message)
    {
        sender.Send(message);
    }
}
