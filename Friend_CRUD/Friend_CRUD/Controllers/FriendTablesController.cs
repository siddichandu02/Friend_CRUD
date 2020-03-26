using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Friend_CRUD.Models;

namespace Friend_CRUD.Controllers
{
    public class FriendTablesController : Controller
    {
        private FriendDBEntities db = new FriendDBEntities();

        // GET: FriendTables
        public ActionResult Index()
        {
            return View(db.FriendTables.ToList());
        }

        // GET: FriendTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FriendTable friendTable = db.FriendTables.Find(id);
            if (friendTable == null)
            {
                return HttpNotFound();
            }
            return View(friendTable);
        }

        // GET: FriendTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FriendTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
       // [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FriendId,FriendName,Place")] FriendTable friendTable)
        {
            if (ModelState.IsValid)
            {
                db.FriendTables.Add(friendTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(friendTable);
        }

        // GET: FriendTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FriendTable friendTable = db.FriendTables.Find(id);
            if (friendTable == null)
            {
                return HttpNotFound();
            }
            return View(friendTable);
        }

        // POST: FriendTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FriendId,FriendName,Place")] FriendTable friendTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(friendTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(friendTable);
        }

        // GET: FriendTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FriendTable friendTable = db.FriendTables.Find(id);
            if (friendTable == null)
            {
                return HttpNotFound();
            }
            return View(friendTable);
        }

        // POST: FriendTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FriendTable friendTable = db.FriendTables.Find(id);
            db.FriendTables.Remove(friendTable);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
