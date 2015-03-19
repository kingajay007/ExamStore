using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExamStore.Models
{
    public class Exam : BaseEntity
    {
        public Exam()
        {
            this.Questions = new List<Question>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name="Exam Code")]
        public string ExamCode { get; set; }

        public string Description { get; set; }
        public Decimal Duration { get; set; }

        [Required]
        [Display(Name="Active")]
        public bool IsActive { get; set; }

        

        public virtual IList<Question> Questions { get; set; }
    }
}