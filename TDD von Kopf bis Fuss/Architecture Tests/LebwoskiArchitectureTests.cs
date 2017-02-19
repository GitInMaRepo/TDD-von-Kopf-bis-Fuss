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
        Mock<IFramesInGame> framesInGame;
        Mock<IBowlingCalculator> calculator;
        Mock<IBowlingOutput> output;
        ArchitectureTestingFactory factory;

        [TestInitialize]
        public void Initialize()
        {
            framesInGame = new Mock<IFramesInGame>();
            calculator = new Mock<IBowlingCalculator>();
            output = new Mock<IBowlingOutput>();
            calculator.Setup(f => f.Calculate()).Returns(new List<int> { 3 });
            output.Setup(f => f.FormatOutput(It.IsAny<List<int>>())).Returns("1:3 2:7");
            factory = new ArchitectureTestingFactory();
            factory.framesInGame = framesInGame.Object;
            factory.bowlingCalculator = calculator.Object;
            factory.bowlingOutput = output.Object;
        }

        [TestMethod]
        public void Calling_CreateFrame_Twice_Creates_An_Internal_Result()
        {
            var target = new BowlingService(factory);
            var frame1 = target.CreateFrame("1", "2");
            var frame2 = target.CreateFrame("3", "4");
            target.Add(frame1);
            target.Add(frame2);
            framesInGame.Verify(f => f.AddFrame(frame1),Times.Once);
            framesInGame.Verify(f => f.AddFrame(frame2),Times.Once);
        }

        [TestMethod]
        public void Calling_Calculate_Creates_The_Endresult()
        {
            var target = new BowlingService(factory);
            var frame1 = target.CreateFrame("1", "2");
            target.Add(frame1);
            target.CalculateGame();
            calculator.Verify(f => f.Calculate(), Times.Once);
            var capsulatedTarget = new PrivateObject(target);
            var resultToAssert = (List<int>)capsulatedTarget.GetProperty("calculationResult");
            resultToAssert.Should().BeEquivalentTo(new List<int>() { 3 });
        }

        [TestMethod]
        public void Calling_Output_Creates_The_Formatted_Result()
        { 
            var target = new BowlingService(factory);
            var frame1 = target.CreateFrame("1", "2");
            var frame2 = target.CreateFrame("3", "4");
            target.Add(frame1);
            target.Add(frame2);
            target.CalculateGame();
            string resultToAssert = target.GetOutput();
            output.Verify(f => f.FormatOutput(It.IsAny<List<int>>()), Times.Once);
            resultToAssert.Should().Be("1:3 2:7");
        }
    }
}
