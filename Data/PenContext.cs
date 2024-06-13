using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pen.Models;

namespace Pen.Data
{
    public class PenContext : DbContext
    {
        public PenContext (DbContextOptions<PenContext> options)
            : base(options)
        {
        }

        public DbSet<Pen.Models.Pens> Pens { get; set; } = default!;
    }
}
