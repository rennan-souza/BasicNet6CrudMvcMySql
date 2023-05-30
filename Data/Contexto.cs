using Microsoft.EntityFrameworkCore;
using Net6CrudMvcMySql.Models;

namespace Net6CrudMvcMySql.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        { }

        public DbSet<Usuario> Usuario { get; set; }

    }
}
