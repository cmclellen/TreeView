using CompanyABC.Common.Utilities;
using CompanyABC.TreeView.DAL.Domain;
using CompanyABC.TreeView.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CompanyABC.TreeView.Web.Controllers.api
{
    public class TreeNodeController : ApiController
    {
        public TreeNodeController(IRepositoryFactory repositoryFactory)
        {
            Guard.NotNull(() => repositoryFactory, repositoryFactory);
            RepositoryFactory = repositoryFactory;
        }

        IRepositoryFactory RepositoryFactory { get; set; }

        ITreeNodeRepository TreeNodeRepository
        {
            get { return RepositoryFactory.GetRepository<ITreeNodeRepository>(); }
        }

        [Route("/")]
        public IList<TreeNode> GetAll()
        {
            return TreeNodeRepository.GetAll();
        }
    }
}