using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebApiRealcional.Data;

namespace WebApiRealcional.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private readonly DataBaseContext _dbContext;

        public AnimalController(DataBaseContext dataBaseContext)
        {
            _dbContext = dataBaseContext;
        }

        [HttpGet("get")]
        public IActionResult getAnimal()
        {
                //obtener a todos los animales con su relacion 
            return Ok(_dbContext.animal.Include(a => a.Tipos).ToArray()) ;
        }

        [HttpPost("Insert")]
        public IActionResult insertAnimal([FromForm] Animal animalRequest)
        {
            try
            {
               var tipo = _dbContext.tipos.Where(c => c.TiposId == animalRequest.TiposId).FirstOrDefault(); 
                if (tipo == null)
                {
                    return StatusCode(400, "No se encontro el objeto a relacionar");
                }
                animalRequest.Tipos = tipo;
                _dbContext.animal.Add(animalRequest);
                _dbContext.SaveChanges();
                return Ok(animalRequest);
            }
            catch (System.Exception ex)
            {

                return StatusCode(500, "Error:=> " + ex);
            }
        }

    }
}
