using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebApiRealcional.Data;

namespace WebApiRealcional.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {
        private readonly DataBaseContext _dataBaseContext;

        public AlumnoController(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        [HttpGet("all")]
        public IActionResult getAll()
        {
            return Ok(_dataBaseContext.alumno.Include(a => a.colegio).ToArray());
        }

        [HttpPost("new/")]
        public IActionResult newAlumno([FromForm] Alumno request)
        {
            try
            {
                var colegio = _dataBaseContext.colegio.Where(c => c.ColegioId == request.ColegioId).FirstOrDefault();
                if (colegio != null)
                {
                    request.colegio = colegio;
                    _dataBaseContext.alumno.Add(request);
                    _dataBaseContext.SaveChanges();
                    return Ok(request);
                }
                return StatusCode(400, "No se encontro el colegio al que se intenta asociar");
            }
            catch (System.Exception ex)
            {
                return StatusCode(500, "error" + ex);
            }
        }
    }
}
