using Entities.POCOs;
using RepositoryEFCore.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEFCore.Repositories
{
    public class SeguimientoRepository : ISeguimientoRepository
    {
        readonly DataContexDb contexto;
        public SeguimientoRepository(DataContexDb dataContexDb)
        {
            contexto = dataContexDb;
        }

        public void CreateSeguimiento(Seguimiento seguimiento)
        {
            contexto.Add(seguimiento);
        }

        public IEnumerable<Seguimiento> GetAll()
        {
            return contexto.Seguimientos;
        }
    }
}
