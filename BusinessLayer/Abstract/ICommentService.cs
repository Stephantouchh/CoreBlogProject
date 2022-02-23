using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void CommentAdd(Comment comment);
        //  void CommentDelete(Comment comment);
        //  void CommentUpdate(Comment comment);
        List<Comment> GetList(int id);
        //    Comment GetById(int id);
    }
}
