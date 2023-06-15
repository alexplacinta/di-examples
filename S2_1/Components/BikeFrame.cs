namespace S2_1.Components;

public class SpecializedBikeFrame
{
    private FizikSaddle _saddle;
    private FsaHandlebar _handlebar;
    private DTSwissWheel _frontWheel;
    private DTSwissWheel _rearWheel;

    public SpecializedBikeFrame()
    {
        _saddle = new FizikSaddle();
        _handlebar = new FsaHandlebar();
        _frontWheel = new DTSwissWheel();
        _rearWheel = new DTSwissWheel();
    }
}