using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        /*
        [TestMethod]
        public void ()
        {
        }
        */

        // Positive Test Cases
        [TestMethod]
        public void EmptyStringReturnsTrueForSomeReason()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        [TestMethod]
        public void OnlyBracketsReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void NestedBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[]]"));
        }

        [TestMethod]
        public void WordPrecedingBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("word[]"));
        }

        [TestMethod]
        public void WordFollowingBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]word"));
        }

        [TestMethod]
        public void BracketsSurroundingWordReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[word]"));
        }

        // Negative Test Cases
        [TestMethod]
        public void OnlyOpeningBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }

        [TestMethod]
        public void OnlyClosingBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }

        [TestMethod]
        public void ReversedBracketsReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        [TestMethod]
        public void OneOpeningBracketAndTwoClosingBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[]]"));
        }

        [TestMethod]
        public void TwoOpeningBracketsAndOneClosingBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[[]"));
        }

        [TestMethod]
        public void TwoClosingOneOpeningBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]]["));
        }

        [TestMethod]
        public void OneClosingTwoOpeningBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("][["));
        }


        // NTC: "[", "]", "[]]", "[[]", "]][", "][["
    }
}
