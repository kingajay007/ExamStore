using ExamStore.Data;
using ExamStore.Models;
using ExamStore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamStore.Controllers
{
    public class ExamController : Controller
    {
        IRepository<Exam> _repository = new EfRepository<Exam>();
        // GET: Exam
        public ActionResult Index()
        {
            
            return View(_repository.GetAll());
        }

        // GET: Exam/Details/5
        public ActionResult Details(int id)
        {
            return View(_repository.FindById(id));
        }

        // GET: Exam/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Exam/Create
        [HttpPost]
        public ActionResult Create(Exam Exam)
        {
            try
            {
                //Exam.Created = DateTime.Now;
                //Exam.Modified = DateTime.Now;
                //Exam.UserId = "8525c7e6-a0e7-4f7b-a6b4-51304b09aa33";
                if (ModelState.IsValid)
                {
                    _repository.Create(Exam);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View(Exam);
            }
        }

        // GET: Exam/Edit/5
        public ActionResult Edit(int id)
        {
            var exam = _repository.FindById(id);
            if (exam==null)
            {
                return HttpNotFound();
            }
            
            return View(exam);
        }

        // POST: Exam/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Exam Exam)
        {
            try
            {
                //Exam.UserId = "8525c7e6-a0e7-4f7b-a6b4-51304b09aa33";
                if (ModelState.IsValid)
                {
                    //Exam.Modified = DateTime.Now;
                    _repository.Update(id,Exam);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View(Exam);
            }
        }

        // GET: Exam/Delete/5
        public ActionResult Delete(int id)
        {
            var exam = _repository.FindById(id);
            if (exam==null)
            {
                return HttpNotFound("Exam Not Found");
            }
            return View(exam);
        }

        // POST: Exam/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Exam Exam)
        {
            try
            {
                _repository.Delete(Exam);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(Exam);
            }
        }
    }
}
