using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class Message2Manager : IMessage2Service
    {
        IMessage2Dal _message2Dal;

        public Message2Manager(IMessage2Dal messageDal)
        {
            _message2Dal = messageDal;
        }

        public List<Message2> GetInboxListByWriter(int id)
        {
            return _message2Dal.GetListWithMessageByWriter(id);
        }

        public List<Message2> GetList(Expression<Func<Message2, bool>> filter = null)
        {
            return _message2Dal.GetListAll(filter);
        }

        public void TAdd(Message2 t)
        {
            _message2Dal.Insert(t);
        }

        public void TDelete(Message2 t)
        {
            _message2Dal.Delete(t);
        }

        public Message2 TGetByFilter(Expression<Func<Message2, bool>> filter = null)
        {
            return _message2Dal.GetByFilter(filter);
        }

        public Message2 TGetById(int id)
        {
            return _message2Dal.GetByID(id);
        }

        public void TUpdate(Message2 t)
        {
            _message2Dal.Update(t);
        }
    }
}
