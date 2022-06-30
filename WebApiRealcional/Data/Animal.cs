namespace WebApiRealcional.Data
{
    public class Animal
    {
        public int AnimalId { get; set; }
        public string Name { get; set; }

        public int TiposId { get; set; }

        public Tipos Tipos { get; set; }
    }
}
