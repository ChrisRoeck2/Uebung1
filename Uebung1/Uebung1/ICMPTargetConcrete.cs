using System;

public class ICMPTargetConcrete : AbstractTarget
{
	public ICMPTargetConcrete()
	{
	}

    public override bool check()
    {
		if (Address.Contains("42"))
		{
			FailedConsecutiveChecks = 0;
			return true;
		}
		else
		{
			FailedConsecutiveChecks++;
			return false;
		}
    }

	public bool testCheck()
	{
        foreach (AbstractNotificationSender notification in notificationSenders)
        {
            if (FailedConsecutiveChecks >= notification.Threshhold)
            {
                notification.Send(FailureMessage);
				return true;
            }
        }
		return false;
    }
}
