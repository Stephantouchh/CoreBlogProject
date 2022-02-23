using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void TAdd(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        T TGetById(int id);
        T TGetByFilter(Expression<Func<T, bool>> filter = null);
    }
}
