using ExamStore.Data;
using ExamStore.Models;
using ExamStore.Services;
using ExamStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamStore.Controllers
{
    public class QuestionController : Controller
    {
        IRepository<Question> _repository = new EfRepository<Question>();
        // GET: Question
        public ActionResult Index()
        {
            return View(_repository.GetAll());
        }

        // GET: Question/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Question/Create
        public ActionResult Create(int id =0)
        {
            if (id>0)
            {
                var Question = _repository.FindById(id);
                if (Question!=null)
                {
                    return View(Question);
                }
                else
                {
                    return View(new Question());
                }
                
            }
            else
            {
                return View(new Question());
            }
            
        }

        // POST: Question/Create
        [HttpPost]
        public ActionResult Create(Question Question)
        {
            try
            {
                _repository.Create(Question);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Question/Edit/5
        public ActionResult Edit(int id)
        {
            var Question = _repository.FindById(id);
            for (int i = 0; i < Question.NumberOfOptions; i++)
            {
                Question.Options.Add(new Option { QuestionId=Question.Id});
            }
            return View(Question);
        }

        // POST: Question/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Question Question)
        {
            try
            {
                var Q = _repository.FindById(Question.Id);
                Q.Options = Question.Options;
                _repository.Update(Question.Id,Q);
                

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Question/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Question/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
