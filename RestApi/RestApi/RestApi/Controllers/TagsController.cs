using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestApi.Controllers
{
    public class TagsController : Controller
    {
        //
        // GET: /Tags/

        public ActionResult Index()
        {
            return View();
        }

    }
}
