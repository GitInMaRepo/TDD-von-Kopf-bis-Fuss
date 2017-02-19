using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lebowski_Special;
using Moq;
using System.Collections.Generic;
using FluentAssertions;

namespace TDD_von_Kopf_bis_Fuss
{
    [TestClass]
    public class LebwoskiArchitectureTests
    {
        [TestMethod]
        public void Calling_CreateFrame_Twice_Creates_An_Internal_Result()
        {
            var frameListToAssert = new Mock<IFramesInGame>();
            var calculator = new Mock<IBowlingCalculator>();
            var output = new Mock<IBowlingOutput>();

            var target = new BowlingService(frameListToAssert.Object, calculator.Object, output.Object);
            var frame1 = target.CreateFrame("1", "2");
            var frame2 = target.CreateFrame("3", "4");
            target.Add(frame1);
            target.Add(frame2);

            frameListToAssert.Verify(f => f.AddFrame(frame1),Times.Once);
            frameListToAssert.Verify(f => f.AddFrame(frame2),Times.Once);
        }

        [TestMethod]
        public void Calling_Calculate_Creates_The_Endresult()
        {
            var frameList = new Mock<IFramesInGame>();
            var calculatorToAssert = new Mock<IBowlingCalculator>();
            calculatorToAssert.Setup(f => f.Calculate()).Returns(new List<int> { 3 });
            var output = new Mock<IBowlingOutput>();

            var target = new BowlingService(frameList.Object, calculatorToAssert.Object, output.Object);
            var frame1 = target.CreateFrame("1", "2");
            target.Add(frame1);
            target.CalculateGame();

            calculatorToAssert.Verify(f => f.Calculate(), Times.Once);
            var capsulatedTarget = new PrivateObject(target);
            var resultToAssert = (List<int>)capsulatedTarget.GetProperty("calculationResult");
            resultToAssert.Should().BeEquivalentTo(new List<int>() { 3 });
        }

        [TestMethod]
        public void Calling_Output_Creates_The_Formatted_Result()
        {
            var frameList = new Mock<IFramesInGame>();
            var calculator = new Mock<IBowlingCalculator>();
            var outputToAssert = new Mock<IBowlingOutput>();
            outputToAssert.Setup(f => f.FormatOutput(It.IsAny<List<int>>())).Returns("1:3 2:7");

            var target = new BowlingService(frameList.Object, calculator.Object, outputToAssert.Object);
            var frame1 = target.CreateFrame("1", "2");
            var frame2 = target.CreateFrame("3", "4");
            target.Add(frame1);
            target.Add(frame2);

            target.CalculateGame();
            string resultToAssert = target.GetOutput();
            outputToAssert.Verify(f => f.FormatOutput(It.IsAny<List<int>>()), Times.Once);
            resultToAssert.Should().Be("1:3 2:7");
        }
    }
}
