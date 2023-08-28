using RepositoryEFCore.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEFCore.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContexDb Contexto;

        public UnitOfWork(DataContexDb dataContexDb)
        {
            Contexto = dataContexDb;
        }
        public Task<int> SaveChanges()
        {
            try
            {
                return Contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
