using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyController : ControllerBase
    {
        private ICountryRepository _repository;

        //private RepositoryContext _repositoryContext;

        public MyController(ICountryRepository repository)
        {
            _repository = repository;
        }
        
        /*public MyController(RepositoryContext repositoryContext) {}*/

        [HttpGet]
        public IEnumerable<Country> getAll()
        {
            var x = _repository.FindAll();
            return x;
        }
    }
}
