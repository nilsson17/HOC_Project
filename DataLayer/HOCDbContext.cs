using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class HOCDbContext : DbContext
    {
        public HOCDbContext _context;

        public HOCDbContext()
            : base("name=HOCDbContext")
        {
        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Dog> Dog { get; set; }
    }
}
