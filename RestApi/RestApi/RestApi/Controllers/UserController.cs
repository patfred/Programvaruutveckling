using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestApi.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Get(int id)
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Update(int id)
        {
            return View();
        }
        public ActionResult Delete(int id)
        {
            return View();
        }
        public ActionResult LogOn(string email,  string password)
        {
            return View();
        }
        public ActionResult LogOn(string email)
        {
            return View();
        }

    }
}
