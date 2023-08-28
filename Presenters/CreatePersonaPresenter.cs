using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCasePorts;

namespace Presenters
{
    public class CreatePersonaPresenter : ICreatePersonaOutputPort, IPresenter<PersonaDTO>
    {
        public PersonaDTO Content { get; private set; } = null!;

        public Task Handle(PersonaDTO Persona)
        {
            Content = Persona;
            return Task.CompletedTask;
        }
    }
}
