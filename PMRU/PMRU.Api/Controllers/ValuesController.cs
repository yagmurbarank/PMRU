using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using PMRU.Application.UnitOfWorks;
using PMRU.Domain.Entities;

namespace PMRU.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public ValuesController( IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task< IActionResult> Get()
        {
            //null değer döndürüyor
            return Ok(await unitOfWork.GetReadRepository<Employee>().GetAllAsync());
        }
       
    }
}
