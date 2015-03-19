using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Data.Models
{
    class Test
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int Description { get; set; }
        //public int CategoryId { get; set; }
        public Decimal Duration { get; set; }
        public bool IsActive { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
