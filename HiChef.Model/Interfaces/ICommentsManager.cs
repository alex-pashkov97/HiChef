using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HiChef.Model.Models;

namespace HiChef.Model.Interfaces
{
    public interface ICommentsManager
    {
        //Task<Comment> GetCommentsByUserGuid(Guid userGuid);

        Task<List<Comment>> GetCommentsByRecipeGuid(Guid userGuid);

        Task<Comment> SaveComment(Comment comment);

        Task DeleteComment(Guid commentGuid);
    }
}
