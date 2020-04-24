using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWT_API_NETCORE.Repository.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT_API_NETCORE.Base
{   
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BasesController<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository _repository;

        public BasesController(TRepository repository) { this._repository = repository; }
        
    }
}