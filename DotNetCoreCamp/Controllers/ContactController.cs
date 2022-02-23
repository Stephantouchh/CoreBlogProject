using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DotNetCoreCamp.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactRepository());

        //private readonly INotyfService _notyf;

        //public ContactController(INotyfService notyf)
        //{
        //    _notyf = notyf;
        //}

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact p)
        {
            p.ContactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.ContactStatus = true;
            cm.ContactAdd(p);
            //_notyf.Success("Mesajınız Başarılı Bir Şekilde İletildi.");
            return RedirectToAction("Index", "Blog");
        }
    }
}
