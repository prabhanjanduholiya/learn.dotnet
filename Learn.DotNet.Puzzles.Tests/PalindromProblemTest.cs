using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learn.DotNet.Puzzles.Tests
{
    [TestClass]
    public class PalindromProblemTest
    {
        [TestMethod()]
        public void IsPalindromStringTest()
        {
            var result = PalindromProblem.IsPalindromString("iTopiNonAvevanoNipoti");

            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void IsNotPalindromStringTest()
        {
            var result = PalindromProblem.IsPalindromString("duholiya");

            Assert.IsFalse(result);
        }
    }
}




