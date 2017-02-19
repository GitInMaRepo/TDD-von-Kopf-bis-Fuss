using System;
using System.Collections.Generic;

namespace Lebowski_Special
{
    public class BowlingService : IBowlingService
    {
        private IBowlingFactory bowlingFactory;

        private List<int> calculationResult { get; set; }

        public BowlingService(IBowlingFactory factory)
        {
            bowlingFactory = factory;
        }

        public void Add(Frame frame)
        {
            bowlingFactory.framesInGame.AddFrame(frame);
        }

        public List<byte> GetLatestResult()
        {
            return new List<byte>();
        }

        public void CalculateGame()
        {
            calculationResult = bowlingFactory.bowlingCalculator.Calculate();
        }

        public Frame CreateFrame(string wurf1, string wurf2)
        {
            var frame = new Frame();
            frame.Roll1 = wurf1;
            frame.Roll2 = wurf2;
            return frame;
        }

        public string GetOutput()
        {
            return bowlingFactory.bowlingOutput.FormatOutput(calculationResult);
        }
    }
}