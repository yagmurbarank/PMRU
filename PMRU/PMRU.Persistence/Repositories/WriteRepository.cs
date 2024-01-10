using Microsoft.EntityFrameworkCore;
using PMRU.Application.Interfaces.Repositories;
using PMRU.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : class, IEntityBase, new()
    {
        private DbContext dbContext;

        public WriteRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        private DbSet<T> Table { get => dbContext.Set<T>(); }

        public async Task CreateAsync(T entity)
        {
            await Table.AddAsync(entity);
        }
        public async Task AddRangeAsync(IList<T> entities)
        {
            await Table.AddRangeAsync(entities);
        }

        public async Task DeleteAsync(T entity)
        {
            await Task.Run(() => Table.RemoveRange(entity));
        }

        public async Task<T> AddAsync(T entity)
        {
            await Task.Run(() => Table.Add(entity));
            return entity;
        }
        public async Task<T> UpdateAsync(T entity)
        {
            await Task.Run(() => Table.Update(entity));
            return entity;
        }
        public async Task DeleteRangeAsync(List<T> entity)
        {
            await Task.Run(() => Table.RemoveRange(entity));
        }
        public async Task<bool> HardDeleteAsync(T entity)
        {
            await Task.Run(() => Table.Remove(entity));
            await Task.Run(() => Table.AddAsync(entity));
            return true; // return true if delete was successfull
        }
    }
}
