using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace TDD_von_Kopf_bis_Fuss
{
    [TestClass]
    public class Zuerst_mal_das
    {
        [TestMethod]
        public void DieSolutionSollBauenUndDerTestLaufen()
        {
            var fail = true;
            fail.Should().BeTrue();
        }
    }
}
