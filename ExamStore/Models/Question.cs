using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamStore.Models
{
    public class Question : BaseEntity
    {
        public Question()
        {
            this.Categories = new List<Category>();
            this.Exams = new List<Exam>();
            this.Options = new List<Option>();
        }
        
        public int Id { get; set; }

        [Display(Name="Question")]
        [Required]
        public string Query { get; set; }

        //[Display(Name = "Tags")]
        //public string Tags { get { return string.Join(",", TagList); } set; }

        //public IList<string> TagList { get {return Tags.Split(new char[]{','},50) ;} set; }
        enum DifficultyLevel
        {
            Easy,Normal,Hard
        } ;

        [Display(Name="Number of Options")]
        public int NumberOfOptions { get; set; }

        public virtual IList<Category> Categories { get; set; }
        public virtual IList<Option> Options { get; set; }
        public virtual IList<Exam> Exams { get; set; }

    }
}