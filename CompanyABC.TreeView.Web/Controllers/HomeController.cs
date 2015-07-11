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
        public HomeController()
        {
            
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
