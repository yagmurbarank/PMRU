using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using PMRU.Application.Interfaces.Repositories;
using PMRU.Domain.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace PMRU.Persistence.Repositories
{

    public class ReadRepository<T> : IReadRepository<T> where T : class, IEntityBase, new()
    {
    
        private DbContext dbContext;

        public ReadRepository(DbContext dbContext)
        {
           this.dbContext = dbContext;
          //dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
         }
        //null değer döndürüyor
         private DbSet<T> Table { get => dbContext.Set<T>(); }

        public async Task<IList<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, bool enableTracking = false)
         {
           IQueryable<T> queryable = Table;
            if (!enableTracking) queryable = queryable.AsNoTracking();
            if (include is not null) queryable = include(queryable);
            if (predicate is not null) queryable = queryable.Where(predicate);
            if (orderBy is not null)
              return await orderBy(queryable).ToListAsync();

         return await queryable.ToListAsync();

         }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, bool enableTracking = false)
        {
            IQueryable<T> queryable = Table;
            if (!enableTracking) queryable = queryable.AsNoTracking();
            if (include is not null) queryable = include(queryable);

            //queryable.Where(predicate);

            return await queryable.FirstOrDefaultAsync(predicate);
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate, bool enableTracking = false)
        {
            if (!enableTracking) Table.AsNoTracking();
            return Table.Where(predicate);
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await Table
                .AsNoTracking()
                .FirstOrDefaultAsync(e => EF.Property<int>(e, "Id") == id);
        }

        public Task<T?> GetByIdAsync(int id, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, bool enableTracking = false)
        {
            throw new NotImplementedException();
        }
    }
}
