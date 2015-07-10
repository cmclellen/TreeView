using CompanyABC.Common.Utilities;
using CompanyABC.TreeView.DAL.Repositories;
using CompanyABC.TreeView.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace CompanyABC.TreeView.Web.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IRepositoryFactory repositoryFactory)
        {
            Guard.NotNull(() => repositoryFactory, repositoryFactory);
            RepositoryFactory = repositoryFactory;
        }

        IRepositoryFactory RepositoryFactory { get; set; }

        ITreeNodeRepository TreeRepository
        {
            get { return RepositoryFactory.GetRepository<ITreeNodeRepository>(); }
        }

        public ActionResult Index(int? treeDepth)
        {
            var treeData = TreeRepository.GetAll();
            return View(new TreeModel {
                Depth = treeDepth.GetValueOrDefault(0),
                TreeData = treeData,
            });
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
