using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExamStore.Models
{
    [NotMapped]
    public class QuestionMap
    {
        public int Id { get; set; }

        public int QuestionId { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public Question Question { get; set; }
    }
}