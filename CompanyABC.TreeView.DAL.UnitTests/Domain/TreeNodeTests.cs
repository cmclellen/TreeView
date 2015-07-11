using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CompanyABC.TreeView.DAL.Domain;
using System.Linq;
using CompanyABC.Common.Extensions;

namespace CompanyABC.TreeView.DAL.UnitTests.Domain
{
    [TestClass]
    public class TreeNodeTests
    {
        [TestMethod]
        public void Equals_BothEqualTreeNodeInstancesCompared_ReturnTrue()
        {
            // ARRANGE
            TreeNode treeNode = new TreeNode("aaa")
            {
                TreeNodes = Enumerable.Empty<TreeNode>().ToList()
            };

            // ACT
            var actual = treeNode.Equals(treeNode.DeepCopy());

            // ASSERT
            Assert.IsTrue(actual, "Instances are equal.");
        }

        [TestMethod]
        public void Equals_NonEqualTreeNodeInstancesCompared_ReturnFalse()
        {
            // ARRANGE
            TreeNode treeNode1 = new TreeNode("aaa")
            {
                TreeNodes = Enumerable.Empty<TreeNode>().ToList()
            };
            TreeNode treeNode2 = treeNode1.DeepCopy();
            treeNode2.TreeNodes.Add(new TreeNode("bbb"));

            // ACT
            var actual = treeNode1.Equals(treeNode2);

            // ASSERT
            Assert.IsFalse(actual, "Instances are not equal.");
        }

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
