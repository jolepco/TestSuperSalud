using Entities.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEFCore
{
    public interface ISeguimientoRepository
    {
        void CreateSeguimiento(Seguimiento seguimiento);
        IEnumerable<Seguimiento> GetAll();

    }
}
