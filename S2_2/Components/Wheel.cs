namespace S2_2.Components;

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
    public DTSwissWheel() : base(new ContinentalTyre())
    {
    }
}

public class EastonWheel : Wheel
{
    public EastonWheel() : base(new MaxxisTyre())
    {
    }
}