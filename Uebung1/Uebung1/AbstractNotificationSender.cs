using System;

public abstract class AbstractNotificationSender : INotificationSender
{
    public AbstractNotificationSender()
    {
    }

    public int Threshhold { get; set; } = 0;

    public string Recipient { get; set; }


    public abstract bool Send(string message);
}
