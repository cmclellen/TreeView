using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CompanyABC.TreeView.DAL.Domain;

namespace CompanyABC.TreeView.DAL.UnitTests.Domain
{
    [TestClass]
    public class TreeNodeTests
    {
        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void ctor_NullValueSuppliedAsDisplayText_ExceptionThrown()
        {
            // ARRANGE

            // ACT
            new TreeNode(null);

            // ASSERT
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void ctor_EmptyStringSuppliedAsDisplayText_ExceptionThrown()
        {
            // ARRANGE
            
            // ACT
            new TreeNode(string.Empty);

            // ASSERT
        }

    }
}
