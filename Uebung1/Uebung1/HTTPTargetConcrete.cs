using System;

public class HTTPTargetConcrete : AbstractTarget
{
	public HTTPTargetConcrete()
	{
	}

    public override bool check()
    {
        return base.Address.Contains("42") ? true : false;
    }
}
