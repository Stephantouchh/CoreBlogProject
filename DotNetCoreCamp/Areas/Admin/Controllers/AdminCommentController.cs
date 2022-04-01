using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreCamp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminCommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());

        public IActionResult Index()
        {
            var comment = commentManager.GetCommentWithBlog();
            return View(comment);
        }
    }
}
