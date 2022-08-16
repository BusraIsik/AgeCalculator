using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgeCalculator.Controllers
{
    public class PartialController : Controller
    {
        // GET: Partial
        public ActionResult Header()
        {
            return PartialView();
        }

        public ActionResult Footer()
        {
            return PartialView();
        }

        public ActionResult MenuSideBar()
        {
            return PartialView();
        }
    }
}