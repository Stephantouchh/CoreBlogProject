using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository repo;

        public CategoryManager()
        {
            repo = new EfCategoryRepository();
        }
        public void CategoryAdd(Category category)
        {
            repo.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            repo.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            repo.Update(category);
        }

        public Category GetById(int id)
        {
            return repo.GetByID(id);
        }

        public List<Category> GetList()
        {
            return repo.GetListAll();
        }
    }
}
