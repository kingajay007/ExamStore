using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.AspNet.Identity;

[assembly: OwinStartup(typeof(ExamStore.Startup))]

namespace ExamStore
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions() { 
            LoginPath= new PathString("/Home/Login"),
            AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
            });
        }
    }
}
