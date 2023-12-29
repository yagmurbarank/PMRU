using Microsoft.EntityFrameworkCore.Query;
using PMRU.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;



namespace PMRU.Application.Interfaces.Repositories
{
    public interface IReadRepository<T> where T : class, IEntityBase,new()
    {
        
        Task<T> GetAsync(Expression<Func<T, bool>> predicate,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
            bool enableTracking = false);

        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            bool enableTracking = false);

        IQueryable<T> Find(Expression<Func<T, bool>> predicate, bool enableTracking = false);

        public  Task<T?> GetByIdAsync(int id,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
            bool enableTracking = false);
    }
}

/*
GetAll ve GetAllAsync farkı =>  GetAll çağrılınca cevap gelene kadar bekler ve metot tamamlanınca
diğer işlemlere devam eder. GetAllAsync ise bekleme yapmaz. I/O yoğun işlemlerinde tercih edilir,
performans artışı sağlar.
predicate: Filtreleme amacıyla bir lambda ifadesi alır. Bu, T türündeki öğeleri filtrelemek için kullanılır. 
Örneğin, employee => employee.DepartmentId == 1 gibi bir ifade verilebilir.
include: Entity Framework gibi ORM (Object-Relational Mapping) araçlarından alınan verilerde ilişkisel verileri dahil etmek için kullanılır. 
Bu, öğelerin belirli ilişkili özellikleriyle birlikte getirilmesini sağlar.
orderBy: Öğelerin sıralanması için bir lambda ifadesi alır. 
Örneğin, query => query.OrderBy(employee => employee.Name) gibi bir ifade verilebilir.
enableTracking: İzleme (tracking) durumunu belirlemek için kullanılır. İzleme, bir nesnenin değişikliklerini takip etme yeteneğini ifade eder. 
Bu durumun açık olması, değişiklikleri takip etmenizi sağlar, ancak performansı etkileyebilir.
 */