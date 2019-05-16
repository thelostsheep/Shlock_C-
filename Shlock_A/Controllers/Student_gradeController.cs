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
    public class Student_gradeController : Controller
    {
        private MyDB db = new MyDB();

        // GET: Student_grade
        public ActionResult Index()
        {
            return View(db.Student_grade.ToList());
        }

        // GET: Student_grade/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_grade student_grade = db.Student_grade.Find(id);
            if (student_grade == null)
            {
                return HttpNotFound();
            }
            return View(student_grade);
        }

        // GET: Student_grade/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student_grade/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Student_gradeID,Student_ID,Student_Name,Student_Sex,Courses_Name,Courses_Grad")] Student_grade student_grade)
        {
            if (ModelState.IsValid)
            {
                db.Student_grade.Add(student_grade);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(student_grade);
        }

        // GET: Student_grade/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_grade student_grade = db.Student_grade.Find(id);
            if (student_grade == null)
            {
                return HttpNotFound();
            }
            return View(student_grade);
        }

        // POST: Student_grade/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Student_gradeID,Student_ID,Student_Name,Student_Sex,Courses_Name,Courses_Grad")] Student_grade student_grade)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student_grade).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student_grade);
        }

        // GET: Student_grade/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_grade student_grade = db.Student_grade.Find(id);
            if (student_grade == null)
            {
                return HttpNotFound();
            }
            return View(student_grade);
        }

        // POST: Student_grade/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Student_grade student_grade = db.Student_grade.Find(id);
            db.Student_grade.Remove(student_grade);
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
