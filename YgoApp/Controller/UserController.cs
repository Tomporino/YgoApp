using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using YgoApp.Models;
using YgoApp.Models.Repositories;

namespace YgoApp.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _users;
        
        public UserController(IUserRepository users)
        {
            _users = users;    
        }

        [HttpPost]
        public ActionResult AddNewUser(User user)
        {
            _users.Add(user);
            return NoContent();
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            return _users.GetUsers().ToList();
        }

        [HttpGet("getName/{userId}")]
        public ActionResult<User> GetUser(long userId)
        {
            User user = _users.Get(userId);
            if (user != null)
            {
                return user;
            }
            else
            {
                return NotFound($"User with id {userId} not found!");
            }
        }

        [HttpGet("getId/{userName}")]
        public ActionResult<long> GetUserIdByName(string userName)
        {
            User user = _users.Get(userName);
            if (user != null)
            {
                return user.Id;
            }
            else
            {
                return NotFound($"User with name {userName} not found!");
            }
        }

        [HttpDelete("delete/{userId}")]
        public ActionResult DeleteUser(long userId)
        {
            User user = _users.Get(userId);
            if (user != null)
            {
                _users.Delete(user);
                return NoContent();
            }
            else
            {
                return NotFound($"User with Id {userId} not found!");
            }
        }
    }

}