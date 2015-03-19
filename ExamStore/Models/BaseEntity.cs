using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamStore.Models
{
    public class BaseEntity
    {
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        //[Required]
        public string UserCreatedId { get; set; }
        public virtual ApplicationUser UserCreated { get; set; }

        public string UserModifiedId { get; set; }
        public virtual ApplicationUser UserModified { get; set; }
    }
}