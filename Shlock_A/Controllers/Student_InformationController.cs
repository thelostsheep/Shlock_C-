using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Shlock_A.Models;

namespace Shlock_A.Controllers
{
    public class Student_InformationController : Controller
    {
        private MyDB db = new MyDB();

        // GET: Student_Information
        public ActionResult Index()
        {
            return View(db.Student_Information.ToList());
        }

        // GET: Student_Information/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_Information student_Information = db.Student_Information.Find(id);
            if (student_Information == null)
            {
                return HttpNotFound();
            }
            return View(student_Information);
        }

        // GET: Student_Information/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student_Information/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Xueshengxuehao,Xueshengxingming,Xueshengxingbie")] Student_Information student_Information)
        {
            if (ModelState.IsValid)
            {
                db.Student_Information.Add(student_Information);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(student_Information);
        }

        // GET: Student_Information/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_Information student_Information = db.Student_Information.Find(id);
            if (student_Information == null)
            {
                return HttpNotFound();
            }
            return View(student_Information);
        }

        // POST: Student_Information/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Xueshengxuehao,Xueshengxingming,Xueshengxingbie")] Student_Information student_Information)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student_Information).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student_Information);
        }

        // GET: Student_Information/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_Information student_Information = db.Student_Information.Find(id);
            if (student_Information == null)
            {
                return HttpNotFound();
            }
            return View(student_Information);
        }

        // POST: Student_Information/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Student_Information student_Information = db.Student_Information.Find(id);
            db.Student_Information.Remove(student_Information);
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
