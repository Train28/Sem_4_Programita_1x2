using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sem_4_Programita_1x2.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext (DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }
        
        public DbSet<Factura> objF { get; set; }

    }
}