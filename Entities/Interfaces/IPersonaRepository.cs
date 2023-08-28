using Entities.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEFCore
{
    public interface IPersonaRepository
    {
        void CreatePersona(Persona Persona);
        IEnumerable<Persona> GetAll();



    }
}
