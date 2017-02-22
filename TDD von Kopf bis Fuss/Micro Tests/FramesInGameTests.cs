using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lebowski_Special;
using FluentAssertions;

namespace TDD_von_Kopf_bis_Fuss.Micro_Tests
{
    [TestClass]
    public class FramesInGameTests
    {
        [TestMethod]
        public void Adding_Frames()
        {
            var target = new FramesInGame();
            target.AddFrame(new Frame());
            target.Frames.Count.Should().Be(1);
        }
    }
}
