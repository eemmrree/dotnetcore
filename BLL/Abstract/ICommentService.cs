using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL.Concrete;

namespace BLL.Abstract
{
    public interface ICommentService
    {
        void CommentAdd(Comment comment);
        //void CommentDelete(Comment comment);
        //void CommentUpdate(Comment comment);
        List<Comment> GetList(int id);
        //Comment GetById(int id);
    }
}
