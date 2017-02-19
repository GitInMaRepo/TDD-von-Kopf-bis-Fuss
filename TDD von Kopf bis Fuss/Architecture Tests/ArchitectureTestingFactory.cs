using System;
using Lebowski_Special;

namespace TDD_von_Kopf_bis_Fuss
{
    internal class ArchitectureTestingFactory : IBowlingFactory
    {
        public ArchitectureTestingFactory()
        {
        }

        internal void CreateObjects()
        {
        }

        public IBowlingCalculator bowlingCalculator { get; set; }

        public IBowlingOutput bowlingOutput { get; set; }

        public IFramesInGame framesInGame { get; set; }
    }
}