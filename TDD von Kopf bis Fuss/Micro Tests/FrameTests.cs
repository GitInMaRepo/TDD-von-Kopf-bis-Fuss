using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lebowski_Special;
using FluentAssertions;

namespace TDD_von_Kopf_bis_Fuss.Micro_Tests
{
    [TestClass]
    public class FrameTests
    {
        [TestMethod]
        public void Throw_1_and_7_gives_a_frame_result_of_8()
        {
            var target = new Frame();
            target.Roll1 = "1";
            target.Roll2 = "7";
            target.Calculate();
            target.ResultValue.Should().Be(8);
        }

        [TestMethod]
        public void Throw_1_and_9_gives_a_frame_result_Spare()
        {
            var target = new Frame();
            target.Roll1 = "1";
            target.Roll2 = "9";
            target.Calculate();
            target.IsSpare.Should().BeTrue();
        }

        [TestMethod]
        public void Throw_10_gives_a_frame_result_Strike()
        {
            var target = new Frame();
            target.Roll1 = "10";
            target.Roll2 = "X";
            target.Calculate();
            target.IsStrike.Should().BeTrue();
        }
    }
}
