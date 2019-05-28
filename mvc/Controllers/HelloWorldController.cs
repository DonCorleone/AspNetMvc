using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        // public string Index()
        // {
        //     return "This is my <b>default</b> action...";
        // }

        // 
        // GET: /HelloWorld/Welcome/ 

        public ActionResult Welcome(string name, int numTimes = 1) {

            base.ViewBag.Message = "Hello " + name;
            base.ViewBag.NumTimes = numTimes;

            return base.View();
        }

        // public string Welcome2(string name, int ID = 1)
        // {
        //     return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        // }

        public ActionResult Index(){
            return base.View();
        }
    }
}
