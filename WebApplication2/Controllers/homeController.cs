using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{//aghaye taghipoor
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {

            var model = new products
            {
                Id=1,
                BrandName="salam",
                ModeINO="salaminfo"


            };
            return View(model);
        }
    }
}