using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TodoService.Services
{
    public interface IService<T>
    {
        public Task<T> Get(Guid id);
        public Task<List<T>> GetAll();
        public Task<T> Create(T entity);
        public Task<T> Update(T entity);
        public Task Delete(T entity);
    }
}