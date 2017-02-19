using System;
using System.Collections.Generic;

namespace Lebowski_Special
{
    public class BowlingService : IBowlingService
    {
        private IFramesInGame framesInGame;
        private IBowlingCalculator bowlingCalculator;
        private IBowlingOutput bowlingOutput;

        private List<int> calculationResult { get; set; }

        public BowlingService(IFramesInGame frames, IBowlingCalculator calculator, IBowlingOutput output)
        {
            framesInGame = frames;
            bowlingCalculator = calculator;
            bowlingOutput = output;
        }

        public void Add(Frame frame)
        {
            framesInGame.AddFrame(frame);
        }

        public List<byte> GetLatestResult()
        {
            return new List<byte>();
        }

        public void CalculateGame()
        {
            calculationResult = bowlingCalculator.Calculate();
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
            return bowlingOutput.FormatOutput(calculationResult);
        }
    }
}