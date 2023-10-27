using Microsoft.AspNetCore.Mvc;
using Examen.Context;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DiscoControle : ControllerBase
    {
        private readonly ILogger<DiscoControle> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public DiscoControle(
            ILogger<DiscoControle> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear estudiantes
        //[Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Disco disco)
        {
            _aplicacionContexto.Disco.Add(disco);
            _aplicacionContexto.SaveChanges();
            return Ok(disco);
        }
        //READ: Obtener lista de estudiantes
        //[Route("")]
        [HttpGet]

        public IEnumerable<Disco> Get()
        {
            return _aplicacionContexto.Disco.ToList();
        }

        //Update: Modificar estudiantes
        //[Route("/id")]
        [HttpPut]
        public IActionResult Put([FromBody] Disco disco)
        {
            _aplicacionContexto.Disco.Update(disco);
            _aplicacionContexto.SaveChanges();
            return Ok(disco);

        }
        //Delete: Eliminar estudiantes
        //[Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int discoID)
        {
            _aplicacionContexto.Disco.Remove(
                _aplicacionContexto.Disco.ToList()
                .Where(x=>x.idDisco == discoID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(discoID);
        }
    }
}