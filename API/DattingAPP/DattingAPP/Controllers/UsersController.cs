using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DattingAPP.Data;
using DattingAPP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DattingAPP.Controllers
{
    
    [ApiController]
    [Route("api/[controller]/[Action]")]
    public class UsersController : ControllerBase
    {
        public DattingAppDBContext _dattingAppDBContext;
        public UsersController(DattingAppDBContext dattingAppDBContext)
        {
            _dattingAppDBContext = dattingAppDBContext;
        }

        //get user List
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>>  GetUsers()
        {
            var users = await _dattingAppDBContext.Users.ToListAsync();
            return  users;
        }


        //getuserbyId
        [HttpGet]
        public async Task<ActionResult<AppUser>> GetUserById(int Id)
        {
            var user = await _dattingAppDBContext.Users.FindAsync(Id);
            return user;
        }
    }
}
