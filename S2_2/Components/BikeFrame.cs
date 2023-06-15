namespace S2_2.Components;

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
    public SpecializedBikeFrame() 
        : base(new FizikSaddle(), new FsaHandlebar(), new DTSwissWheel(), new DTSwissWheel())
    {
    }
}

public class GTBikeFrame : BikeFrame
{
    public GTBikeFrame() : base(new RitcheySaddle(), new TruvativHandlebar(), new EastonWheel(), new EastonWheel())
    {
    }
}