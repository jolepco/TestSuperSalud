using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEFCore
{
    public interface IUnitOfWork
    {
        Task<int> SaveChanges();
    }
}
