using Microsoft.AspNetCore.Mvc;
using PostgresIntegration.Database;

namespace PostgresIntegration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        BusinessContext _context;
        IConfiguration _configuration;

        public UserController(IConfiguration configuration, BusinessContext context)
        {
            _context = context;
            _configuration = configuration;
        }

        // GET: UserController
        public ActionResult Index()
        {
            return Ok("Tudo ok!");
        }

        [HttpPost]
        public ActionResult Post(Model.User user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

