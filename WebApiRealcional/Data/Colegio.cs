using System.Collections.Generic;

namespace WebApiRealcional.Data
{
    public class Colegio
    {
        public int ColegioId { get; set; }
        public string Name { get; set; }

        public ICollection<Alumno> alumnos { get; set; }
    }
}
