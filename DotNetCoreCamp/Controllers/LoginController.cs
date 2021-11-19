using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DotNetCoreCamp.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Writer writer)
        {
            Context c = new Context();
            var datavalue = c.Writers.FirstOrDefault(x => x.WriterMail == writer.WriterMail && x.WriterPassword == writer.WriterPassword);
            if (datavalue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,writer.WriterMail)
                };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                return View();
            }


            //Context c = new Context();
            //var datavalue = c.Writers.FirstOrDefault(x => x.WriterMail == writer.WriterMail && x.WriterPassword == writer.WriterPassword);
            //if (datavalue != null)
            //{
            //    HttpContext.Session.SetString("username", writer.WriterMail);
            //    return RedirectToAction("Index", "Writer");
            //}
            //else
            //{
            //    return View();
            //}
        }
    }
}
