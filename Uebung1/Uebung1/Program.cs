using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        AbstractTarget t = new HTTPTargetConcrete();
        t.getNotificationSenders().Add(new SMSSenderConcrete());
        Console.WriteLine(t.getNotificationSenders()[0].ToString());


        /*
        List<AbstractTarget> targets = new List<AbstractTarget>();
        HTTPTargetConcrete http1 = new HTTPTargetConcrete()
        {
            ID = Guid.NewGuid().ToString(),
            Address = "10.66.66.42",
            Name = "BotNet C2 Master",
            FailureMessage = "Kurwa!",
            FailedConsecutiveChecks = 1,
            IntervalSeconds = 30
        };
        targets.Add(http1);

        foreach (AbstractTarget target in targets)
        {
            target.check();
        }

        Console.WriteLine(targets[0].ToString());
        Console.ReadKey();*/
    }
}