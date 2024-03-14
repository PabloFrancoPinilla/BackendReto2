using Microsoft.AspNetCore.Mvc;
using TeatroBack.Models;
using TeatroBack.Business;
using TeatroBack.Data;

namespace TeteSala.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SalaController : ControllerBase
    {
        private readonly ISalaService _SalaService;

        public SalaController(ISalaService SalaService)
        {
            _SalaService = SalaService;
        }

        [HttpGet]
        public ActionResult<List<SalaDto>> GetAll() => _SalaService.GetAll();

        [HttpGet("{id}")]
        public ActionResult<Sala> Get(int id)
        {
            var Sala = _SalaService.Get(id);

            if (Sala == null)
                return NotFound("hehe que loco");

            return Ok(Sala);
        }

        [HttpPost]
        public IActionResult Create([FromBody] SalaCreateDto SalaCreateDto)

        {
            if (SalaCreateDto == null)
            {
                return BadRequest();
            }

            var Sala = new Sala
            {
                Numero = SalaCreateDto.Numero,
                SessionId = SalaCreateDto.SessionId
            };
            _SalaService.Add(Sala);
            return CreatedAtAction(nameof(Get), new { id = Sala.Id }, Sala);
        }



        [HttpPut("{id}")]
        public IActionResult Update(int id, Sala Sala)
        {
            if (id != Sala.Id)
                return BadRequest();

            var existingSala = _SalaService.Get(id);
            if (existingSala == null)
                return NotFound();

            _SalaService.Update(Sala);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Sala = _SalaService.Get(id);

            if (Sala == null)
                return NotFound();

            _SalaService.Delete(id);

            return NoContent();
        }


    }
}
