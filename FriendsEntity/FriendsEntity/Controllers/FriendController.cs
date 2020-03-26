using FriendsEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FriendsEntity.Controllers
{
    public class FriendController : Controller
    {
        private FiendsEntities db = new FiendsEntities();

        public ActionResult Index()
        {
            return View(db.FriendTables.ToList());
        }

    }
}