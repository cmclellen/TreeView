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

        public ActionResult Index(int? treeDepth)
        {
            return View(new TreeModel {
                Depth = treeDepth.GetValueOrDefault(0)
            });
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
