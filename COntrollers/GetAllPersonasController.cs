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
    public class GetAllPersonasController
    {
        readonly IGetAllPersonasInputPort InputPort;
        readonly IGetAllPersonasOutputPort OutputPort;
        public GetAllPersonasController(IGetAllPersonasInputPort inputPort, IGetAllPersonasOutputPort outputPort)
            => (InputPort, OutputPort) = (inputPort, outputPort);

        [HttpGet]
        public async Task<IEnumerable<PersonaDTO>> getPersonas()
        {
            await InputPort.Handle();
            return ((IPresenter<IEnumerable<PersonaDTO>>)OutputPort).Content;
        }
    }
}
