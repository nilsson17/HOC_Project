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

        public void Seed()
        {
            Person person = new Person();

            person.SSN = "1999015";
            person.FirstName = "Emma";
            person.LastName = "Karlsson";
            person.Gender = "Female";

            Person.Add(person); 
        }
    }
}
