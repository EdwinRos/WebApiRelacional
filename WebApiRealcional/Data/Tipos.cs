using System.Collections.Generic;

namespace WebApiRealcional.Data
{
    public class Tipos
    {
        public int TiposId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Animal> Animals { get; set; }
    }
}
