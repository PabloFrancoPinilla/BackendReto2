using Microsoft.AspNetCore.Mvc;
using TeatroBack.Models;
using TeatroBack.Business;

namespace TeteSeat.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SeatController : ControllerBase
    {
        private readonly ISeatService _SeatService;

        public SeatController(ISeatService SeatService)
        {
            _SeatService = SeatService;
        }

        [HttpGet]
        public ActionResult<List<SeatDto>> GetAll() => _SeatService.GetAll();

        [HttpGet("{id}")]
        public ActionResult<Seat> Get(int id)
        {
            var Seat = _SeatService.Get(id);

            if (Seat == null)
                return NotFound("hehe que loco");

            return Ok(Seat);
        }

        [HttpPost]
        public IActionResult Create([FromBody] SeatCreateDto SeatCreateDto)

        {
            if (SeatCreateDto == null)
            {
                return BadRequest();
            }

            var Seat = new Seat
            {
                Number = SeatCreateDto.Number,
                SessionId = SeatCreateDto.SessionId,
                UserId = SeatCreateDto.UserId,
                State = SeatCreateDto.State
            };
            _SeatService.Add(Seat);
            return CreatedAtAction(nameof(Get), new { id = Seat.Id }, Seat);
        }



        [HttpPut("{id}")]
        public IActionResult Update(int id, Seat Seat)
        {
            if (id != Seat.Id)
                return BadRequest();

            var existingSeat = _SeatService.Get(id);
            if (existingSeat == null)
                return NotFound();

            _SeatService.Update(Seat);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Seat = _SeatService.Get(id);

            if (Seat == null)
                return NotFound();

            _SeatService.Delete(id);

            return NoContent();
        }


    }
}
