namespace Lebowski_Special
{
    public class DefaultFactory : IBowlingFactory
    {
        public DefaultFactory()
        {
        }

        public IBowlingCalculator bowlingCalculator { get; set; }

        public IBowlingOutput bowlingOutput { get; set; }

        public IFramesInGame framesInGame { get; set; }

        public void CreateObjects()
        {
            bowlingCalculator = new BowlingCalculator();
            bowlingOutput = new BowlingOutput();
            framesInGame = new FramesInGame();
        }
    }
}