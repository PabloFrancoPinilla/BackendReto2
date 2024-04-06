using Microsoft.AspNetCore.Mvc;
using TeatroBack.Models;
using TeatroBack.Business;

namespace TeatroBack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReserveController : ControllerBase
    {
        private readonly IReserveService _reserveService;

        public ReserveController(IReserveService reserveService)
        {
            _reserveService = reserveService;
        }

        [HttpGet]
        public ActionResult<List<Reserve>> GetAll() => _reserveService.GetAll();

        [HttpGet("{id}")]
        public ActionResult<Reserve> Get(int id)
        {
            var reserve = _reserveService.Get(id);

            if (reserve == null)
            {
                return NotFound();
            }
            return Ok(reserve);
        }

        [HttpPost]
        public IActionResult Create([FromBody] ReserveCreateDto reserveCreateDto)
        {
            if (reserveCreateDto == null)
            {
                return BadRequest();
            }

            var reserve = new Reserve
            {
                SeatId = reserveCreateDto.SeatId,
                SessionId = reserveCreateDto.SessionId,
                UserId = reserveCreateDto.UserId
            };

            _reserveService.Add(reserve);
            return CreatedAtAction(nameof(Get), new { id = reserve.Id }, reserve);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Reserve reserve)
        {
            if (!ModelState.IsValid) return BadRequest();

            if (id != reserve.Id)
                return BadRequest();

            var existingReserve = _reserveService.Get(id);
            if (existingReserve == null)
                return NotFound();

            _reserveService.Update(reserve);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var reserve = _reserveService.Get(id);

            if (reserve == null)
                return NotFound();

            _reserveService.Delete(id);

            return Ok();
        }

        [HttpGet("{userId}/seats")]
        public IActionResult GetSeatsByUserId(int userId)
        {
            var seats = _reserveService.GetSeatsByUserId(userId);
            return Ok(seats);
        }
      
    }
}
