using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VSGitTest.Controllers
{
    public class HelloController : Controller
    {
        //
        // GET: /Hello/
        public ActionResult Index()
        {
            return View();
        }

        public string Index1()
        {
            string str = "v1.0.0.1 fix bug";
            return "v1.0.0.0 Add"+str;
        }
	}
}