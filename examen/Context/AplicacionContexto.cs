using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace Examen.Context
{
    public class AplicacionContexto : DbContext
    {
        public AplicacionContexto
            (DbContextOptions<AplicacionContexto> options)
            : base(options) { }

        public DbSet<Disco> Disco { get; set; }
        public DbSet<Musica> Musica { get; set; }

    }
}
