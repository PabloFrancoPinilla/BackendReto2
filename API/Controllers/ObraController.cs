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
        public ActionResult<List<Obra>> GetAll() => _ObraService.GetAll();

        [HttpGet("{id}")]
        public ActionResult<Obra> Get(int id)
        {
            var Obra = _ObraService.Get(id);

            if (Obra == null)
                return NotFound("hehe que loco");

            return Ok(Obra);
        }

        [HttpPost]
        public IActionResult Create(Obra Obra)
        {
            _ObraService.Add(Obra);
            return CreatedAtAction(nameof(Get), new { id = Obra.Id }, Obra);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Obra Obra)
        {
            if (id != Obra.Id)
                return BadRequest();

            var existingObra = _ObraService.Get(id);
            if (existingObra == null)
                return NotFound();

            // Actualiza solo las propiedades de la obra
            existingObra.Name = Obra.Name;
            existingObra.Image = Obra.Image;
            existingObra.Duration = Obra.Duration;
            existingObra.Genre = Obra.Genre;
            existingObra.Sessions = Obra.Sessions;

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


    }
}
