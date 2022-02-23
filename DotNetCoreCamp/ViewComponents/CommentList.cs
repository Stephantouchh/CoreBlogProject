using DotNetCoreCamp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DotNetCoreCamp.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    Username="Nihat"
                },
                new UserComment
                {
                    ID=2,
                    Username="Mesut"
                },
                new UserComment
                {
                    ID=3,
                    Username="Merve"
                }
            };
            return View(commentvalues);
        }
    }
}
