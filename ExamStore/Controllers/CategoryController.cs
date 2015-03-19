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
    public class CategoryController : Controller
    {
        IRepository<Category> _repository = new EfRepository<Category>();
        // GET: Category
        public ActionResult Index()
        {

            return View(_repository.GetAll());
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            return View(_repository.FindById(id));
        }

        // GET: Category/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Category/Create
        [HttpPost]
        public ActionResult Create(Category Category)
        {
            try
            {
                //Category.Created = DateTime.Now;
                //Category.Modified = DateTime.Now;
                //Category.UserId = "8525c7e6-a0e7-4f7b-a6b4-51304b09aa33";
                if (ModelState.IsValid)
                {
                    _repository.Create(Category);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View(Category);
            }
        }

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            var exam = _repository.FindById(id);
            if (exam == null)
            {
                return HttpNotFound();
            }

            return View(exam);
        }

        // POST: Category/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Category Category)
        {
            try
            {
                //Category.UserId = "8525c7e6-a0e7-4f7b-a6b4-51304b09aa33";
                if (ModelState.IsValid)
                {
                    //Category.Modified = DateTime.Now;
                    _repository.Update(id, Category);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View(Category);
            }
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            var exam = _repository.FindById(id);
            if (exam == null)
            {
                return HttpNotFound("Category Not Found");
            }
            return View(exam);
        }

        // POST: Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Category Category)
        {
            try
            {
                _repository.Delete(Category);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(Category);
            }
        }
    }
}
