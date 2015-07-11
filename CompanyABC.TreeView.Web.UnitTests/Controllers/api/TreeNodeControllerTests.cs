using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CompanyABC.TreeView.Web.Controllers.api;
using CompanyABC.TreeView.DAL.Repositories;
using Moq;
using CompanyABC.TreeView.DAL.Domain;

namespace CompanyABC.TreeView.Web.UnitTests.Controllers.api
{
    [TestClass]
    public class TreeNodeControllerTests
    {
        Mock<ITreeNodeRepository> TreeNodeRepositoryMock { get; set; }
        TreeNodeController TreeNodeController {get;set;}
        Mock<IRepositoryFactory> RepositoryFactoryMock { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            TreeNodeRepositoryMock = new Mock<ITreeNodeRepository>();
            RepositoryFactoryMock = new Mock<IRepositoryFactory>();
            RepositoryFactoryMock
                .Setup(svc => svc.GetRepository<ITreeNodeRepository>())
                .Returns(TreeNodeRepositoryMock.Object);
            TreeNodeController = new TreeNodeController(RepositoryFactoryMock.Object);
        }

        [TestMethod]
        public void GetAll_SuccessfulRetrieval_RetrievedEntitiesReturned()
        {
            // ARRANGE
            TreeNodeRepositoryMock
                .Setup(svc => svc.GetAll())
                .Returns(new[]{
                    new TreeNode("aaa"),
                    new TreeNode("bbb"),
                });

            // ACT
            var actual = TreeNodeController.GetAll();

            // ASSERT
            Assert.IsNotNull(actual, "Expected non-null result.");
            var expected = new[]{
                new TreeNode("aaa"),
                new TreeNode("bbb"),
            }.ToList();
            CollectionAssert.AreEqual(expected, actual.ToList(), "Expected result not returned.");
        }
    }
}
