using PMRU.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*GetAll ve GetAllAsync farkı =>  GetAll çağrılınca cevap gelene kadar bekler ve metot tamamlanınca
diğer işlemlere devam eder. GetAllAsync ise bekleme yapmaz. I/O yoğun işlemlerinde tercih edilir,
performans artışı sağlar.*/

namespace PMRU.Application.Interfaces.Repositories
{
    public interface IReadRepository<T> where T : class, IEntityBase,new()
    {

    }
}
