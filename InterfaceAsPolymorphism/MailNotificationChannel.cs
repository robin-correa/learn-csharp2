namespace InterfaceAsPolymorphism;

public class MailNotificationChannel : INotificationChannel
{
    public void Send(Message message)
    {
        Console.WriteLine("Sending mail...");
    }
}