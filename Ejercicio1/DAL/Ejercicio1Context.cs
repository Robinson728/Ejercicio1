using Microsoft.EntityFrameworkCore;
using Ejercicio1.Models.DataModels;

namespace Ejercicio1.DAL
{
    public class Ejercicio1Context : DbContext
    {
        public Ejercicio1Context(DbContextOptions<Ejercicio1Context> options): base(options)
        {

        }

        public DbSet<User>? Users { get; set; }
        public DbSet<Curso>? Cursos { get; set; }
    }
}
