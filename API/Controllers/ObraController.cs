using Microsoft.AspNetCore.Mvc;
using TeatroBack.Models;
using TeatroBack.Business;

namespace TeteObra.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ObraController : ControllerBase
    {
        private readonly IObraService _ObraService;

        public ObraController(IObraService obraService)
        {
            _ObraService = obraService;
        }

        [HttpGet]
        public ActionResult<List<ObraDto>> GetAll() => _ObraService.GetAll();

        [HttpGet("{id}")]
        public ActionResult<Obra> Get(int id)
        {
            var Obra = _ObraService.Get(id);

            if (Obra == null)
            {
                return NotFound("hehe que loco");
            }
            return Ok(Obra);
        }

        [HttpPost]
        public IActionResult Create([FromBody] ObraCreateDto obraCreateDto)
        {
            if (obraCreateDto == null)
            {
                return BadRequest();
            }
            var obra = new Obra
            {
                Name = obraCreateDto.Name,
                Image = obraCreateDto.Image,
                Duration = obraCreateDto.Duration,
                Genre = obraCreateDto.Genre,
            };

            _ObraService.Add(obra);
            return CreatedAtAction(nameof(Get), new { id = obra.Id }, obra);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, ObraUpdateDto obraDto)
        {
            if (id != obraDto.Id)
                return BadRequest();

            var existingObra = _ObraService.Get(id);
            if (existingObra == null)
                return NotFound();

            existingObra.Name = obraDto.Name;
            existingObra.Image = obraDto.Image;
            existingObra.Genre = obraDto.Genre;
            existingObra.Duration = obraDto.Duration;
            existingObra.Sessions = obraDto.Sessions;

            _ObraService.Update(existingObra);

            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Obra = _ObraService.Get(id);

            if (Obra == null)
                return NotFound();

            _ObraService.Delete(id);

            return Ok();
        }
        [HttpGet("{obraId}/sessions")]
        public IActionResult GetSessionsByObraId(int obraId)
        {
            var sessisons = _ObraService.GetSessionsByObraId(obraId);
            return Ok(sessisons);
        }


    }
}
