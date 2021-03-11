using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IPersonRepository Persons { get; }
        IDogRepository Dogs { get; }
        int Complete();
    }
}
