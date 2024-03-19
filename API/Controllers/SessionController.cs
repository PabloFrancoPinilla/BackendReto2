using Microsoft.AspNetCore.Mvc;
using TeatroBack.Models;
using TeatroBack.Business;

namespace TeteSession.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SessionController : ControllerBase
    {
        private readonly ISessionService _SessionService;
        private readonly ISeatService _SeatsService;

        public SessionController(ISessionService SessionService, ISeatService SeatsService)
        {
            _SessionService = SessionService;
            _SeatsService = SeatsService;
        }

        [HttpGet]
        public ActionResult<List<SessionDto>> GetAll() => _SessionService.GetAll();

        [HttpGet("{id}")]
        public ActionResult<Session> Get(int id)
        {
            var Session = _SessionService.Get(id);

            if (Session == null)
                return NotFound("hehe que loco");

            return Ok(Session);
        }

        [HttpPost]
        public IActionResult Create([FromBody] SessionPostDto SessionPostDto)
        {
            if (SessionPostDto == null)
            {
                return BadRequest();
            }
            var Session = new Session
            {
                ObraId = SessionPostDto.ObraId,
                SalaId = SessionPostDto.SalaId,
                Date = SessionPostDto.Date
                
            };


            _SessionService.Add(Session);
            return CreatedAtAction(nameof(Get), new { id = Session.Id }, Session);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, SessionUpdateDto Session)
        {
            if (id != Session.Id)
                return BadRequest();

            var existingSession = _SessionService.Get(id);
            if (existingSession == null)
                return NotFound();
                existingSession.Obra.Id = Session.ObraId;
                existingSession.SalaId = Session.SalaId;
                existingSession.Date = Session.Date;

            _SessionService.Update(existingSession);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Session = _SessionService.Get(id);

            if (Session == null)
                return NotFound();

            _SessionService.Delete(id);

            return NoContent();
        }

        [HttpGet("{number}/seats")]
        public IActionResult GetSeatsBySession(int number)
        {
            var seats = _SeatsService.GetSeatsBySession(number);
            return Ok(seats);
        }

        [HttpGet("{salaId}/seatsById")]
        public IActionResult GetSeatsBySessionId(int salaId)
        {
            var seats = _SeatsService.GetSeatsBySalaId(salaId);
            return Ok(seats);
        }

    }
}
