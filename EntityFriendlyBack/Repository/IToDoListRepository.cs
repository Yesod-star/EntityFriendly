using EntityFriendlyBack.Data.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFriendlyBack.Repository
{
    public interface IToDoListRepository
    {
        Task<IEnumerable<ToDoListVO>> FindAll();
        Task<ToDoListVO> FindById(long id);
        Task<ToDoListVO> Create(ToDoListVO vo);
        Task<ToDoListVO> Update(ToDoListVO vo);
        Task<bool> Delete(long id);
    }
}
