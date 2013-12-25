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

        public string Index2()
        {
            return "v1.1.0.0 Add";
        }

        public string Index3()
        {
            string str = "Hello";
            return "v1.2.0.0 Add"+str;
        }

        public string Index4()
        {
            return "v1.3.0.0 Add";
        }

        public string Index5()
        {
            return "v1.4.0.0 Add";
        }
	}
}