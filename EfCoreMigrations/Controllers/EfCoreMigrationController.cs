using EfCoreMigrations.Entity;
using EfCoreMigrations.IRepository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EfCoreMigrations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EfCoreMigrationController : ControllerBase
    {
        IEfMigrationE0146Rep IefMigrationE0146 { get; set; }
        public EfCoreMigrationController(IEfMigrationE0146Rep _iefMigrationE0146)
        {
            IefMigrationE0146 = _iefMigrationE0146;
        }

        // GET: api/<EfCoreMigrationController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EfCoreMigrationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EfCoreMigrationController>
        [HttpPost]
        public async Task<bool> Post(EfMigrationE0146 efMigrationE0146)
        {
            var response = await IefMigrationE0146.EfMigrationsSave(efMigrationE0146);
            return response;

        }

        // PUT api/<EfCoreMigrationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EfCoreMigrationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
