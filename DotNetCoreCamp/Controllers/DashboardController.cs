using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DotNetCoreCamp.Controllers
{
    public class DashboardController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
        Context c = new Context();

        public IActionResult Index()
        {
            ViewBag.v1 = blogManager.GetList(x => x.BlogStatus == true).Count();
            ViewBag.v2 = blogManager.GetBlogListByWriter(1).Count();
            ViewBag.v3 = categoryManager.GetList().Count();
            return View();
        }
    }
}
