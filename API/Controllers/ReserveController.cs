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
            if (reserveCreateDto == null || reserveCreateDto.SeatIds == null || reserveCreateDto.SeatIds.Count == 0)
            {
                return BadRequest("La lista de identificadores de asientos está vacía.");
            }

            foreach (var seatId in reserveCreateDto.SeatIds)
            {
                var reserve = new Reserve
                {
                    SeatId = seatId,
                    SessionId = reserveCreateDto.SessionId,
                    UserId = reserveCreateDto.UserId
                };
                _reserveService.Add(reserve);
            }
            
            return Ok("Reservas creadas exitosamente.");
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
