using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PersonalBlog.Models;

namespace PersonalBlog.Controllers
{
    public class PersonalBlogPostModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PersonalBlogPostModels
        public ActionResult Index()
        {
            return View(db.PersonalBlogPostModels.ToList());
        }

        // GET: PersonalBlogPostModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonalBlogPostModel personalBlogPostModel = db.PersonalBlogPostModels.Find(id);
            if (personalBlogPostModel == null)
            {
                return HttpNotFound();
            }
            return View(personalBlogPostModel);
        }

        // GET: PersonalBlogPostModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonalBlogPostModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,Content,CreateTime")] PersonalBlogPostModel personalBlogPostModel)
        {
            if (ModelState.IsValid)
            {
                db.PersonalBlogPostModels.Add(personalBlogPostModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(personalBlogPostModel);
        }

        // GET: PersonalBlogPostModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonalBlogPostModel personalBlogPostModel = db.PersonalBlogPostModels.Find(id);
            if (personalBlogPostModel == null)
            {
                return HttpNotFound();
            }
            return View(personalBlogPostModel);
        }

        // POST: PersonalBlogPostModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,Content,CreateTime")] PersonalBlogPostModel personalBlogPostModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personalBlogPostModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(personalBlogPostModel);
        }

        // GET: PersonalBlogPostModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonalBlogPostModel personalBlogPostModel = db.PersonalBlogPostModels.Find(id);
            if (personalBlogPostModel == null)
            {
                return HttpNotFound();
            }
            return View(personalBlogPostModel);
        }

        // POST: PersonalBlogPostModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PersonalBlogPostModel personalBlogPostModel = db.PersonalBlogPostModels.Find(id);
            db.PersonalBlogPostModels.Remove(personalBlogPostModel);
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
