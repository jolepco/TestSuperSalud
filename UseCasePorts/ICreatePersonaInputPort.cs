using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCasePorts
{
    public interface ICreatePersonaInputPort
    {
        Task Handle(CreatePersonaDTO Persona);
    }
}
