using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamStore.Models
{
    public class Option
    {
        public int Id { get; set; }

        [Required]
        public string Value { get; set; }

        [Display(Name="Correct")]
        public bool IsCorrect { get; set; }

        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
    }
}