using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business.Services;

namespace AppTest.Controllers
{
    public class PersonController : Controller
    {
        //
        // GET: /Person/

        public ActionResult List()
        {
            return View();
        }

    }
}
