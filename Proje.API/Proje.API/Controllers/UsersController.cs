using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Linq;
namespace Proje.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public int ID { get; set; }
        public string Token { get; set; } = "";
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";

        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-12NGJ7T;Initial Catalog=StajProje;Integrated Security=True");
        [HttpGet("GetUser/{email}")]
        public async Task<ActionResult<List<Users>>> GetById(string email)
        {
            using (DataContext ctx = new DataContext(sqlConnection.ConnectionString))
            {
                List<object> randevuListss = new List<object>();
                List<object> randevuList = new List<object>();
                var randevuListt = from d in ctx.Users
                                   select d;
                var ss = randevuListt.Where(x => x.Email == email).FirstOrDefault();
                if (ss != null)
                {
                    randevuListss.Add(ss);
                }
                if (randevuListss.Count == 0)
                {
                    return NotFound();
                }
                else if (randevuListss.Count == 1)
                {
                    return new JsonResult(randevuListss.ToList());
                }
            }
            return null;
        }
    }
}
