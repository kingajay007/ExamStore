﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamStore.Models
{
    public class ApplicationUser : IdentityUser
    {
        public String Name { get; set; }
    }
}