using System;

public class TelegramSenderConcrete : AbstractNotificationSender
{
    public override bool Send(string message)
    {
        return message.Contains("1337") ? true : false;
    }
}
