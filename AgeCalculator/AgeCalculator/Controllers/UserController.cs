using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgeCalculator.Controllers
{
    public class UserController : Controller
    {
        private AgeCalculatorEntities db = new AgeCalculatorEntities();

        // GET: User
        public ActionResult Index()
        {
            var liste = db.Users.ToList();
            return View(liste);
        }
    }
}