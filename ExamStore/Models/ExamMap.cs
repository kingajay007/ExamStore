using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExamStore.Models
{
   [NotMapped]
    public class ExamMap
    {
        public int Id { get; set; }

        public int QuestionId { get; set; }
        public int ExamId { get; set; }

        public Exam Exam { get; set; }
        public Question Question { get; set; }
    }
}