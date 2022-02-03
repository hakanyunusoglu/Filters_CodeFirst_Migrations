using Filters_CodeFirst_Migrations.Filtreler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters_CodeFirst_Migrations.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [ActFilter]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2()
        {
            return View();
        }
        public ActionResult Index3()
        {
            return View();
        }
    }
}