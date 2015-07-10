using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CompanyABC.Common.Extensions;
using System.Linq;

namespace CompanyABC.Common.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SafeSequenceEqual_BothArgsAreNull_ReturnTrue()
        {
            // ARRANGE
            
            // ACT
            bool actual = EnumerableExtensions.SafeSequenceEqual<Object>(null, null);

            // ASSERT
            Assert.IsTrue(actual, "Both args are equal.");
        }

        [TestMethod]
        public void SafeSequenceEqual_Arg1IsNullAndArg2Not_ReturnFalse()
        {
            // ARRANGE
            
            // ACT
            bool actual = EnumerableExtensions.SafeSequenceEqual<Object>(null, Enumerable.Empty<Object>());

            // ASSERT
            Assert.IsFalse(actual, "Args are not equal.");
        }

        [TestMethod]
        public void SafeSequenceEqual_Arg2NotNullAndArg1Is_ReturnFalse()
        {
            // ARRANGE

            // ACT
            bool actual = EnumerableExtensions.SafeSequenceEqual<Object>(Enumerable.Empty<Object>(), null);

            // ASSERT
            Assert.IsFalse(actual, "Args are not equal.");
        }

        [TestMethod]
        public void SafeSequenceEqual_ArgsHaveSameElementsButOutOfSequence_ReturnFalse()
        {
            // ARRANGE
            var arg = new[]{
                1,
                2
            };

            // ACT
            bool actual = EnumerableExtensions.SafeSequenceEqual(arg, arg.Reverse());

            // ASSERT
            Assert.IsFalse(actual, "Args are out of sequence.");
        }

        [TestMethod]
        public void SafeSequenceEqual_ArgsHaveSameElementsAndInSequence_ReturnTrue()
        {
            // ARRANGE
            var arg = new[]{
                1,
                2
            };

            // ACT
            bool actual = EnumerableExtensions.SafeSequenceEqual(arg, arg.DeepCopy());

            // ASSERT
            Assert.IsTrue(actual, "Args are in sequence.");
        }
    }
}
