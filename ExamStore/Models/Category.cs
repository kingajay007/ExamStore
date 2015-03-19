using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamStore.Models
{
    public class Category  : BaseEntity
    {
        public Category()
        {
            this.Questions = new List<Question>();
        }
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string CategoryName { get; set; }

        public virtual IList<Question> Questions { get; set; }
    }
}