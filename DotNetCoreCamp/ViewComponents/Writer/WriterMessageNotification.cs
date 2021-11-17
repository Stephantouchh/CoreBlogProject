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
        Message2Manager mm = new Message2Manager(new EfMessage2Repository());

        public IViewComponentResult Invoke()
        {
            var values = mm.
                GetList(x => x.ReceiverID == 2 && x.MessageStatus == true);
            if (values.Count() > 3)
            {
                values = values.TakeLast(3).ToList();
            }
            return View(values);
        }
    }
}
