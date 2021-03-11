using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HOCDbContext _context;

        public IPersonRepository Persons { get; private set; }
        public IDogRepository Dogs { get; private set; }

        public UnitOfWork(HOCDbContext context)
        {
            _context = context;
            Persons = new PersonRepository(_context);
            Dogs = new DogRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
