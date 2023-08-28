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
    public  class CreateSeguimientoController
    {
        readonly ICreateSeguimientoInputPort InputPort;
        readonly ICreateSeguimientoOutputPort OutputPort;
        public CreateSeguimientoController(ICreateSeguimientoInputPort inputPort, ICreateSeguimientoOutputPort outputPort)
            => (InputPort, OutputPort) = (inputPort, outputPort);

        [HttpPost]
        public async Task<SeguimientoDTO> CreateSeguimiento(CreateSeguimientoDTO Seguimiento)
        {
            await InputPort.Handle(Seguimiento);
            return ((IPresenter<SeguimientoDTO>)OutputPort).Content;
        }
    }
}
