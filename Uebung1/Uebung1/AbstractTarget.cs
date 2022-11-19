using System;

public abstract class AbstractTarget
{
	public string ID { get; set; } = "";
    public string Name { get; set; } = "";
    public string Address { get; set; } = "";
    public int IntervalSeconds { get; set; } = 0;
    public string FailureMessage { get; set; } = "";
    public int FailedConsecutiveChecks { get; set; } = 1;

    public AbstractTarget()
	{
	}

    public abstract bool check();

}
