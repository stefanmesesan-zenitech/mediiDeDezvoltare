using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mesesan_Stefan_Lab2.Models;

namespace Mesesan_Stefan_Lab2.Data
{
    public class Mesesan_Stefan_Lab2Context : DbContext
    {
        public Mesesan_Stefan_Lab2Context (DbContextOptions<Mesesan_Stefan_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Mesesan_Stefan_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Mesesan_Stefan_Lab2.Models.Publisher> Publisher { get; set; }
    }
}
