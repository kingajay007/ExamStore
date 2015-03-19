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
    public class PracticeController : Controller
    {
        IRepository<Exam> _repo = new EfRepository<Exam>();
        // GET: Practice
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SendJSON()
        {
            return View(new Exam());
        }

        [HttpPost]
        public ActionResult SendJSON(int id, Exam Exam)
        {
            
            Exam = _repo.FindById(Exam.Id);
            return Json(Exam);
        }

        [HttpGet]
        public ActionResult ExamDetail()
        {
            return View(new Exam());
        }

        //[HttpGet]
        //public ActionResult ExamDetail(int Id,Exam Exam)
        //{
        //    Exam = _repo.FindById(Id);
        //    return View(Exam);
        //}
    }
}