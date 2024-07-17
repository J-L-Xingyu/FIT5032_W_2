using CodeSnippet.Exercise;
using CodeSnippet.HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeSnippet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            Hello hello = new Hello();
            //ViewBag.Message = "Your application description page.";
            ViewBag.Message = hello.GetHello();
            ExampleDictionary ed = new ExampleDictionary();
            ed.Example();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}