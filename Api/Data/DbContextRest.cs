using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class DbContextRest : DbContext

    {
        public DbContextRest(DbContextOptions<DbContextRest> options) : base(options) 
        { 

        }
        public DbSet<Tarea> Tareas => Set<Tarea>();    }
}
