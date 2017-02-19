using System.Collections.Generic;

namespace Lebowski_Special
{
    public interface IBowlingService
    {
        void Add(Frame frame);
        void CalculateGame();
        Frame CreateFrame(string wurf1, string wurf2);
        List<byte> GetLatestResult();
    }
}