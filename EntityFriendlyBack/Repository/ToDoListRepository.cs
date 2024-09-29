using AutoMapper;
using EntityFriendlyBack.Data.ValueObjects;
using EntityFriendlyBack.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFriendlyBack.Repository
{
    public class ToDoListRepository : IToDoListRepository
    {
        private readonly MyDbContext _context;
        private IMapper _mapper;

        public ToDoListRepository(MyDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ToDoListVO>> FindAll()
        {
            List<ToDoList> products = await _context.ToDoList.ToListAsync();
            return _mapper.Map<List<ToDoListVO>>(products);
        }

        public async Task<ToDoListVO> FindById(long id)
        {
            ToDoList product =
                await _context.ToDoList.Where(p => p.Id == id)
                .FirstOrDefaultAsync();
            return _mapper.Map<ToDoListVO>(product);
        }

        public async Task<ToDoListVO> Create(ToDoListVO vo)
        {
            ToDoList product = _mapper.Map<ToDoList>(vo);
            _context.ToDoList.Add(product);
            await _context.SaveChangesAsync();
            return _mapper.Map<ToDoListVO>(product);
        }
        public async Task<ToDoListVO> Update(ToDoListVO vo)
        {
            ToDoList product = _mapper.Map<ToDoList>(vo);
            _context.ToDoList.Update(product);
            await _context.SaveChangesAsync();
            return _mapper.Map<ToDoListVO>(product);
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                ToDoList product =
                await _context.ToDoList.Where(p => p.Id == id)
                    .FirstOrDefaultAsync();
                if (product == null) return false;
                _context.ToDoList.Remove(product);
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
