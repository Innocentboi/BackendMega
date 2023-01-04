using Backend.Database.MasterDBEntities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        MasterDbContext masterDb = new MasterDbContext();
        // GET: api/<LocationController>
        [HttpGet]
        public IEnumerable<MsStorageLocation> Get()
        {
            return masterDb.MsStorageLocations.ToList();
        }

        // GET api/<LocationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
    }
}
