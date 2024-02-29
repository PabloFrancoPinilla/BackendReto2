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
        public ActionResult<List<User>> GetAll() => _UserService.GetAll();

        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
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
        public IActionResult Update(int id, User User)
        {
            if (id != User.Id)
                return BadRequest();

            var existingUser = _UserService.Get(id);
            if (existingUser == null)
                return NotFound();

            _UserService.Update(User);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var User = _UserService.Get(id);

            if (User == null)
                return NotFound();

            _UserService.Delete(id);

            return NoContent();
        }
        [HttpGet("{userId}/seats")]
        public IActionResult GetSeatsByUserId(int userId)
        {
            var seats = _SeatService.GetSeatsByUserId(userId);
            return Ok(seats);
        }


    }
}
