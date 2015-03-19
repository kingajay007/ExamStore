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
    public class OptionController : Controller
    {
        IRepository<Option> _repository = new EfRepository<Option>();
        IRepository<Question> _questionRepository = new EfRepository<Question>();

        // GET: Option
        public ActionResult Index()
        {
            return View();
        }

        // GET: Option/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Option/Create
        public ActionResult Create(int QuestionId)
        {
            List<Option> list = null;
            if (QuestionId>0)
            {
                var Question = _questionRepository.FindById(QuestionId);
                list = new List<Option>();
                for (int i = 0; i < Question.NumberOfOptions; i++)
                {
                    list.Add(new Option { QuestionId=QuestionId});
                }
            }
            else
            {
                return View();
            }
            return View(list);
        }

        // POST: Option/Create
        [HttpPost]
        public ActionResult Create(List<Option> Options)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Option/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Option/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Option/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Option/Delete/5
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
