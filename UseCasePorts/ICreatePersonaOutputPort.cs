using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCasePorts
{
    public interface ICreatePersonaOutputPort
    {
        Task Handle(PersonaDTO Persona);
    }
}
