using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloASP.Models
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Temp = "+1s";
            ViewBag.Text1 = "苟利国家生死以";
            ViewBag.Text2 = "发送时间";


            return View();
        }
    }
}