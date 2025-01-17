namespace ObjectOrientedProgramming;

public interface INotification<TMessage> where TMessage : IMessage
{
    void Notify(TMessage message);
}
