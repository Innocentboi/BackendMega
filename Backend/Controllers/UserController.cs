using Backend.Database.MasterDBEntities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        MasterDbContext masterDb=new MasterDbContext();
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<MsUser> Get()
        {
            return masterDb.MsUsers.ToList();
        }

        // GET api/<UserController>/5
        [HttpGet("{userName}/{password}")]
        public string Get(string userName,string password)
        {
            return masterDb.MsUsers.Where(x=>x.UserName==userName && x.Password==password).Select(x => x.UserType).FirstOrDefault().ToString();
        }
    }
}
