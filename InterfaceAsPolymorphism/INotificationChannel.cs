namespace InterfaceAsPolymorphism;

public interface INotificationChannel
{
    void Send(Message message);
}