using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Test()
        {
            return View();
        }
        public ActionResult CheckTime(string name,int? nunber)
        {
            if(nunber == 13)
            {
                ViewBag.time = "下午1點";
            }
            else if (nunber == 14)
            {
                ViewBag.time = "下午2點";
            }
            else if(nunber == 15)
            {
                ViewBag.time = "下午3點";
            }
            else if(nunber == 16)
            {
                ViewBag.time = "下午4點";
            }
            else if(nunber == 17)
            {
                ViewBag.time = "下午5點";
            }
            else if(nunber == 18)
            {
                ViewBag.time = "下午6點";
            }
            else
            {
                ViewBag.time = "數字輸入錯誤，請輸入介於13~18";
            }
            ViewBag.name = name;
            return View();
        }
    }
}