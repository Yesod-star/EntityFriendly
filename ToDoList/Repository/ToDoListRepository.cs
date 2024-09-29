using AutoMapper;
using ListaAfazeres.Context;
using ListaAfazeres.Data.ValueObjects;
using ListaAfazeres.Model;
using Microsoft.EntityFrameworkCore;

namespace ListaAfazeres.Repository
{
    public class ToDoListRepository : IToDoListRepository
    {
        private readonly MySQLContext _context;
        private IMapper _mapper;

        public ToDoListRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TarefaVO>> FindAll()
        {
            List<Tarefa> products = await _context.Tarefas.ToListAsync();
            return _mapper.Map<List<TarefaVO>>(products);
        }

        public async Task<TarefaVO> FindById(long id)
        {
            Tarefa product =
                await _context.Tarefas.Where(p => p.Id == id)
                .FirstOrDefaultAsync();
            return _mapper.Map<TarefaVO>(product);
        }

        public async Task<TarefaVO> Create(TarefaVO vo)
        {
            Tarefa product = _mapper.Map<Tarefa>(vo);
            _context.Tarefas.Add(product);
            await _context.SaveChangesAsync();
            return _mapper.Map<TarefaVO>(product);
        }
        public async Task<TarefaVO> Update(TarefaVO vo)
        {
            Tarefa product = _mapper.Map<Tarefa>(vo);
            _context.Tarefas.Update(product);
            await _context.SaveChangesAsync();
            return _mapper.Map<TarefaVO>(product);
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                Tarefa product =
                await _context.Tarefas.Where(p => p.Id == id)
                    .FirstOrDefaultAsync();
                if (product == null) return false;
                _context.Tarefas.Remove(product);
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
