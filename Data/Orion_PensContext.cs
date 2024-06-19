using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Orion_Pens.Models;

namespace Orion_Pens.Data
{
    public class Orion_PensContext : DbContext
    {
        public Orion_PensContext (DbContextOptions<Orion_PensContext> options)
            : base(options)
        {
        }

        public DbSet<Orion_Pens.Models.Products> Products { get; set; } = default!;
    }
}
