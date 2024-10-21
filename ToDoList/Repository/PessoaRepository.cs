using AutoMapper;
using ListaAfazeres.Context;
using ListaAfazeres.Data.ValueObjects;
using ListaAfazeres.Model;
using Microsoft.EntityFrameworkCore;

namespace ListaAfazeres.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly MySQLContext _context;
        private IMapper _mapper;

        public PessoaRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PessoaVO>> FindAll()
        {
            List<Pessoa> products = await _context.Pessoas.ToListAsync();
            return _mapper.Map<List<PessoaVO>>(products);
        }

        public async Task<PessoaVO> FindById(long id)
        {
            Pessoa product =
                await _context.Pessoas.Where(p => p.Id == id)
                .FirstOrDefaultAsync();
            return _mapper.Map<PessoaVO>(product);
        }

        public async Task<PessoaVO> Create(PessoaVO vo)
        {
            Pessoa product = _mapper.Map<Pessoa>(vo);
            _context.Pessoas.Add(product);
            await _context.SaveChangesAsync();
            return _mapper.Map<PessoaVO>(product);
        }
        public async Task<PessoaVO> Update(PessoaVO vo)
        {
            Pessoa product = _mapper.Map<Pessoa>(vo);
            _context.Pessoas.Update(product);
            await _context.SaveChangesAsync();
            return _mapper.Map<PessoaVO>(product);
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                Pessoa product =
                await _context.Pessoas.Where(p => p.Id == id)
                    .FirstOrDefaultAsync();
                if (product == null) return false;
                _context.Pessoas.Remove(product);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
