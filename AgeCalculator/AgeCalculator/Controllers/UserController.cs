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

        public JsonResult getUser(int userId)
        {
            Users user = db.Users.Find(userId);
            var userObjects = new
            {
                name = user.Name,
                surname = user.Surname,
                birthdate = user.Birthdate.ToString("yyyy-MM-dd"),
                gender = user.Gender,
                city = user.City
            };

            return Json(user, JsonRequestBehavior.AllowGet);
        }
        public JsonResult addUser(string name, string surname, DateTime birthdate, string gender, string city)
        {
            var age = DateTime.Today.Year - birthdate.Year;
            Users user = new Users();
            user.Name = name;
            user.Surname = surname;
            user.Birthdate = birthdate;
            user.Gender = gender;
            user.City = city;
            user.Age = age;
            db.Users.Add(user);
            db.SaveChanges();
            return Json("");
        }

        public JsonResult deleteUser(int userId)
        {
            Users user = db.Users.Find(userId);
            db.Users.Remove(user);
            db.SaveChanges();
            return Json("");
        }

        public JsonResult updateUser(int userId, string name, string surname, DateTime birthdate, string gender, string city)
        {
            var age = DateTime.Today.Year - birthdate.Year;
            Users user = db.Users.Find(userId);
            user.Name = name;
            user.Surname = surname;
            user.Birthdate = birthdate;
            user.Gender = gender;
            user.City = city;
            user.Age = age;
            db.Entry(user);
            db.SaveChanges();
            return Json("");
        }
    }
}