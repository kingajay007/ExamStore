using ExamStore.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamStore.App_Start
{
    public class AuthDbConfig
    {
        public static void RegisterAdmin()
        { 
            using(var context= new StoreContext())
            using(var userStore = new UserStore<ApplicationUser>(context))
            using (var userManager = new UserManager<ApplicationUser>(userStore))
            {
                var user = userStore.FindByNameAsync("admin").Result;
                if (user==null)
                {
                    var AdminUser = new ApplicationUser()
                    {
                        UserName="admin",
                        Email="admin@Examstore.com",
                        Name="Administrator"
                    };

                    userManager.Create(AdminUser,"Ajay_a338");
                }
            }
        }

        
    }
}