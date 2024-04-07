using Microsoft.AspNetCore.Mvc;
using TeatroBack.Models;
using TeatroBack.Business;

namespace TeteUser.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _UserService;
        private readonly ISeatService _SeatService;

        public UserController(IUserService UserService, ISeatService SeatService)
        {
            _UserService = UserService;
            _SeatService = SeatService;
        }



        [HttpGet]
        public ActionResult<List<UserGetDto>> GetAll() => _UserService.GetAll();

        [HttpGet("{id}")]
        public ActionResult<UserGetDto> Get(int id)
        {
            var User = _UserService.Get(id);

            if (User == null)
                return NotFound("hehe que loco");

            return Ok(User);
        }

        [HttpPost]
        public IActionResult Create(User User)
        {
            _UserService.Add(User);
            return CreatedAtAction(nameof(Get), new { id = User.Id }, User);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, User user)
        {
            if (id != user.Id)
                return BadRequest();

            var existingUser = _UserService.GetForUpdate(id);
            if (existingUser == null)
                return NotFound();

            existingUser.Name = user.Name;
            existingUser.LastName = user.LastName;
            existingUser.Mail = user.Mail;
            existingUser.Password = user.Password;

            _UserService.Update(existingUser);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var User = _UserService.GetForUpdate(id);

            if (User == null)
                return NotFound();

            _UserService.Delete(id);

            return NoContent();
        }


    }
}
