﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public Category TGetById(int id)
        {
            return _categoryDal.GetByID(id);
        }
        public List<Category> GetList()
        {
            return _categoryDal.GetListAll();
        }
        public void TAdd(Category t)
        {
            _categoryDal.Insert(t);
        }
        public void TDelete(Category t)
        {
            _categoryDal.Update(t);
        }
        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);
        }

        public List<Category> GetList(Expression<Func<Category, bool>> filter = null)
        {
            return filter == null ?
                 _categoryDal.GetListAll() :
                 _categoryDal.GetListAll(filter);
        }

        public Category TGetByFilter(Expression<Func<Category, bool>> filter = null)
        {
            return filter == null ?
                _categoryDal.GetByFilter() :
                _categoryDal.GetByFilter(filter);
        }
    }
}
