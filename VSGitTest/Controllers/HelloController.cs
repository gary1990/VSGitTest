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
            return "v1.0.0.0 Add";
        }

        public string Index2()
        {
            return "v1.1.0.0 Add";
        }

        public string Index3()
        {
            return "v1.2.0.0 Add";
        }
	}
}