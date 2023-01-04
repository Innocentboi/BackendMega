using Backend.Database.TransactionDB1Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Bpkb1Controller : ControllerBase
    {
        TransactionDb1Context transDb =new TransactionDb1Context();
        // GET: api/<Bpkb1Controller>
        [HttpGet]
        public IEnumerable<TrBpkb> Get()
        {
            return transDb.TrBpkbs.ToList();
        }

        // GET api/<Bpkb1Controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Bpkb1Controller>
        [HttpPost]
        public bool Post([FromBody] TrBpkb bpkb)
        {
            try
            {
                transDb.TrBpkbs.Add(bpkb);
                transDb.SaveChanges();
                return true;
            }
            catch (Exception ex) { return false; }
        }
    }
}
