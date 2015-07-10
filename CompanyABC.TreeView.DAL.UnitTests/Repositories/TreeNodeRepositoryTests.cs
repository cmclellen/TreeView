using CompanyABC.TreeView.DAL.Domain;
using CompanyABC.TreeView.DAL.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyABC.TreeView.DAL.UnitTests.Repositories
{
    [TestClass]
    public class TreeNodeRepositoryTests
    {
        TreeNodeRepository TreeNodeRepository { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            TreeNodeRepository = new TreeNodeRepository();
        }

        [TestMethod]
        public void GetAll_Default_CorrectResultReturned()
        {
            // ARRANGE
            
            // ACT
            var actual = TreeNodeRepository.GetAll();

            // ASSERT
            Assert.IsNotNull(actual, "Expected non-null result.");
            var expected = new[]{
                new TreeNode("Root", new[]{
                    new TreeNode("Folder 1", new []{
                        new TreeNode("Folder 1.1"),
                        new TreeNode("Folder 1.2")
                    }),
                    new TreeNode("Folder 2", new []{
                        new TreeNode("Folder 2.1"),
                        new TreeNode("Folder 2.2", new []{
                            new TreeNode("Folder 2.2.1"),
                            new TreeNode("Folder 2.2.2"),
                            new TreeNode("Folder 2.2.3"),
                        })
                    })
                })
            }.ToList();
            CollectionAssert.AreEqual(expected, actual.ToList(), "Expected result not returned.");
        }
    }
}
