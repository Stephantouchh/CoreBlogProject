using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreCamp.Controllers
{
    [AllowAnonymous]
    public class MessageController : Controller
    {
        Message2Manager mm = new Message2Manager(new EfMessage2Repository());
        public IActionResult InBox()
        {
            int id = 2;
            var values = mm.
                GetInboxListByWriter(id);
            if (values.Count() > 3)
            {
                values = values.TakeLast(3).ToList();
            }
            return View(values);
        }
        public IActionResult MessageDetails(int id)
        {
            var value = mm.TGetById(id);
            return View(value);
        }
    }
}
