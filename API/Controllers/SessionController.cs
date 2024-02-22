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

        public SessionController(ISessionService SessionService)
        {
            _SessionService = SessionService;
        }

        [HttpGet]
        public ActionResult<List<Session>> GetAll() => _SessionService.GetAll();

        [HttpGet("{id}")]
        public ActionResult<Session> Get(int id)
        {
            var Session = _SessionService.Get(id);

            if (Session == null)
                return NotFound("hehe que loco");

            return Ok(Session);
        }

        [HttpPost]
        public IActionResult Create(Session Session)
        {
            _SessionService.Add(Session);
            return CreatedAtAction(nameof(Get), new { id = Session.Id }, Session);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Session Session)
        {
            if (id != Session.Id)
                return BadRequest();

            var existingSession = _SessionService.Get(id);
            if (existingSession == null)
                return NotFound();

            _SessionService.Update(Session);

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


    }
}