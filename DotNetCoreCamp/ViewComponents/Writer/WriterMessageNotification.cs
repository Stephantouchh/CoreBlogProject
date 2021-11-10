using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreCamp.ViewComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {
        MessageManager mm = new MessageManager(new EfMessageRepository());

        public IViewComponentResult Invoke()
        {
            var values = mm.GetList(x => x.Receiver == "deneme@gmail.com" &&
              x.MessageStatus == true);
            if (values.Count() > 3)
            {
                values = values.Take(3).ToList();
            }
            return View(values);
        }
    }
}
