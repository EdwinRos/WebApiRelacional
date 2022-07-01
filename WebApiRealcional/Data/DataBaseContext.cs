using Microsoft.EntityFrameworkCore;


namespace WebApiRealcional.Data
{
    public class DataBaseContext: DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options): base(options)
        {

        }
        public DbSet<Tipos> tipos { get; set; }
        public DbSet<Animal> animal { get; set; }
        public DbSet<Colegio> colegio { get; set; }
        public DbSet<Alumno> alumno { get; set; }
    }
}
