using Entities.POCOs;
using RepositoryEFCore.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEFCore.Repositories
{
    public class PersonaRepository : IPersonaRepository
    {
        readonly DataContexDb contexto;
        public PersonaRepository(DataContexDb dataContexDb)
        {
            contexto = dataContexDb;
        }
        public void CreatePersona(Persona Persona)
        {
            contexto.Add(Persona);
        }

        public IEnumerable<Persona> GetAll()
        {
            return contexto.Personas;
        }
    }
}
