using FriendsEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FriendsEntity.Controllers
{
    public class HomeController : Controller
    {
        private FiendsEntities db = new FiendsEntities();

        public ActionResult Index()
        {
            return View(db.FriendTables.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}