namespace S2_3.Components;

public abstract class Wheel
{
    protected Tyre Tyre;
    
    protected Wheel(Tyre tyre)
    {
        Tyre = tyre;
    }
}

public class DTSwissWheel : Wheel
{
    public DTSwissWheel(Tyre tyre) : base(tyre)
    {
    }
}

public class EastonWheel : Wheel
{
    public EastonWheel(Tyre tyre) : base(tyre)
    {
    }
}