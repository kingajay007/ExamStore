using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExamStore.Models;

namespace ExamStore.ViewModels
{
    public class QuestionOptionViewModel
    {
        public Question Question { get; set; }
        public List<Option> Options { get; set; }
    }
}