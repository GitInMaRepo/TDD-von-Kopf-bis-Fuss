namespace Lebowski_Special
{
    public interface IBowlingFactory
    {
        IBowlingCalculator bowlingCalculator { get; set; }
        IBowlingOutput bowlingOutput { get; set; }
        IFramesInGame framesInGame { get; set; }
    }
}