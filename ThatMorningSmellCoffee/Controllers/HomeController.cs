using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThatMorningSmellCoffee.Models;

namespace ThatMorningSmellCoffee.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private CoffeeAppDBEntities1 Db = new CoffeeAppDBEntities1();
        public ActionResult Index()
        {
             var list = Db.Items.ToList();      
             return View(list);
        }

        public ActionResult About()
        {
            ViewBag.Message = "What better combo could there be?";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "It's a trap!";

            return View();
        }

        public ActionResult Landing()
        {
            return View();
        }
    }


}