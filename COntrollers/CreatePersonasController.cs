using DTOs;
using Microsoft.AspNetCore.Mvc;
using Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCasePorts;

namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreatePersonaController
    {
        readonly ICreatePersonaInputPort InputPort;
        readonly ICreatePersonaOutputPort OutputPort;
        public CreatePersonaController(ICreatePersonaInputPort inputPort, ICreatePersonaOutputPort outputPort)
            => (InputPort, OutputPort) = (inputPort, outputPort);

        [HttpPost]
        public async Task<PersonaDTO> CreatePersona(CreatePersonaDTO Persona)
        {
            await InputPort.Handle(Persona);
            return ((IPresenter<PersonaDTO>)OutputPort).Content;
        }
    }
}
