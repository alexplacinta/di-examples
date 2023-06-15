namespace S2_3.Components;

public abstract class BikeFrame
{
    protected Saddle Saddle;
    protected Handlebar Handlebar;
    protected Wheel FrontWheel;
    protected Wheel RearWheel;

    protected BikeFrame(Saddle saddle, Handlebar handlebar, Wheel frontWheel, Wheel rearWheel)
    {
        Saddle = saddle;
        Handlebar = handlebar;
        FrontWheel = frontWheel;
        RearWheel = rearWheel;
    }
}

public class SpecializedBikeFrame : BikeFrame
{
    public SpecializedBikeFrame(Saddle saddle, Handlebar handlebar, Wheel frontWheel, Wheel rearWheel) : base(saddle, handlebar, frontWheel, rearWheel)
    {
    }
}

public class GTBikeFrame : BikeFrame
{
    public GTBikeFrame(Saddle saddle, Handlebar handlebar, Wheel frontWheel, Wheel rearWheel) : base(saddle, handlebar, frontWheel, rearWheel)
    {
    }
}