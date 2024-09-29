using ListaAfazeres.Data.ValueObjects;

namespace ListaAfazeres.Repository
{
    public interface IToDoListRepository
    {
        Task<IEnumerable<TarefaVO>> FindAll();
        Task<TarefaVO> FindById(long id);
        Task<TarefaVO> Create(TarefaVO vo);
        Task<TarefaVO> Update(TarefaVO vo);
        Task<bool> Delete(long id);
    }
}
