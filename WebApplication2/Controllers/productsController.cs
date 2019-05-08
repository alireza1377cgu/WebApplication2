using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class productsController : Controller
    {


        // GET: products

        // khanoom teymooryian

        public ActionResult Index()
        {
            

            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        // aghay taghipoor
        [HttpPost]
        public ActionResult Create(products entity)
        {

            return RedirectToAction("Index");
        }
        public ActionResult Edit()
        {
            return View();



        }
        // khanoom hekmatii
        public ActionResult Delet()
        {
            return View();



        }



    }


}