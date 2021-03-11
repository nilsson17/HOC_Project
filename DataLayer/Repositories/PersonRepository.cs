using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
   public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(HOCDbContext context) : base(context)
        {

        }

        public HOCDbContext HOC_DbContext
        {
            get { return Context as HOCDbContext; }
        }
    }
}
