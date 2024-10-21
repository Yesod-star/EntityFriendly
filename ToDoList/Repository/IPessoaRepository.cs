using ListaAfazeres.Data.ValueObjects;

namespace ListaAfazeres.Repository
{
    public interface IPessoaRepository
    {
        Task<IEnumerable<PessoaVO>> FindAll();
        Task<PessoaVO> FindById(long id);
        Task<PessoaVO> Create(PessoaVO vo);
        Task<PessoaVO> Update(PessoaVO vo);
        Task<bool> Delete(long id);
    }
}
