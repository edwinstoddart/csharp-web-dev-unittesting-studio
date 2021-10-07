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
        public void OnlyBracketsReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void BracketsSurroundingWordReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[word]"));
        }

        [TestMethod]
        public void WordsSurroundingBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("words[]words"));
        }

        [TestMethod]
        public void WordsInsideAndSurroundingBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("words[words]words"));
        }

        [TestMethod]
        public void NestedBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[]]"));
        }

        [TestMethod]
        public void EmptyStringReturnsTrueForSomeReason()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
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
        public void TwoOpeningBracketsAndOneClosingBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[[]"));
        }

        [TestMethod]
        public void OneOpeningBracketAndTwoClosingBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[]]"));
        }

        [TestMethod]
        public void WordBetweenReversedOrderBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]word["));
        }

        [TestMethod]
        public void OnlyReversedBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }
}
}
