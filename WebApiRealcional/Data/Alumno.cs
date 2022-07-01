namespace WebApiRealcional.Data
{
    public class Alumno
    {
        public int AlumnoId { get; set; }
        public string Name { get; set; }
        public int ColegioId { get; set; }

        public Colegio colegio { get; set; }
    }
}
