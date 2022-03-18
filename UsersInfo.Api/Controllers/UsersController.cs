using Microsoft.AspNetCore.Mvc;
using UsersInfo.Api.Models;

namespace UsersInfo.Api.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<UserDto>> GetUsers()
        {
           return Ok(UsersDataStore.Current.Users);
        }
    }
}
