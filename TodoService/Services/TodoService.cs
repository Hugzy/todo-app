using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TodoService.Models;
using TodoService.Models.Context;

namespace TodoService.Services
{
    
    public class TodoService : IService<TodoList>
    {
        private readonly TodoDbContext _context;
        private readonly ILogger<TodoService> _logger;

        public TodoService(ILogger<TodoService> logger, TodoDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<TodoList> Get(Guid id)
        {
            return await _context.TodoLists.FirstAsync(t => t.Id == id);
        }

        public async Task<List<TodoList>> GetAll()
        {
            return await _context.TodoLists.ToListAsync();
        }

        public async Task<TodoList> Create(TodoList entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TodoList> Update(TodoList entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(TodoList entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}