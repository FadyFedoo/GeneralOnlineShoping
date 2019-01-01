using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GeneralOnlineShoping.DAL;
using GeneralOnlineShoping.Models;

namespace GeneralOnlineShoping.Controllers
{
    public class ItemsController : Controller
    {
        private ShopContext db = new ShopContext();

        // GET: Items
        public ActionResult Index()
        {
            //ShopInitializer si = new ShopInitializer();
            //si.Df(db);
            return View(db.Items.ToList());
        }

        // GET: Items/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemModel itemModel = db.Items.Find(id);
            if (itemModel == null)
            {
                return HttpNotFound();
            }
            return View(itemModel);
        }

        // GET: Items/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Items/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Price,Description")] ItemModel itemModel)
        {
            if (ModelState.IsValid)
            {
                db.Items.Add(itemModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(itemModel);
        }

        // GET: Items/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemModel itemModel = db.Items.Find(id);
            if (itemModel == null)
            {
                return HttpNotFound();
            }
            return View(itemModel);
        }

        // POST: Items/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Price,Description")] ItemModel itemModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(itemModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(itemModel);
        }

        // GET: Items/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemModel itemModel = db.Items.Find(id);
            if (itemModel == null)
            {
                return HttpNotFound();
            }
            return View(itemModel);
        }

        // POST: Items/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ItemModel itemModel = db.Items.Find(id);
            db.Items.Remove(itemModel);
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
