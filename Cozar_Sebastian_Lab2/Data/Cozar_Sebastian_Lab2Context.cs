using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cozar_Sebastian_Lab2.Models;

namespace Cozar_Sebastian_Lab2.Data
{
    public class Cozar_Sebastian_Lab2Context : DbContext
    {
        public Cozar_Sebastian_Lab2Context (DbContextOptions<Cozar_Sebastian_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Cozar_Sebastian_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Cozar_Sebastian_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Cozar_Sebastian_Lab2.Models.Author> Author { get; set; }

        public DbSet<Cozar_Sebastian_Lab2.Models.Category> Category { get; set; }
    }
}
