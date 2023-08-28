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
    public  class GetAllSeguimientoController
    {
        readonly IGetAllSeguimientoInputPort InputPort;
        readonly IGetAllSeguimientoOutputPort OutputPort;
        public GetAllSeguimientoController(IGetAllSeguimientoInputPort inputPort, IGetAllSeguimientoOutputPort outputPort)
            => (InputPort, OutputPort) = (inputPort, outputPort);

        [HttpGet]
        public async Task<IEnumerable<SeguimientoDTO>> getPersonas()
        {
            await InputPort.Handle();
            return ((IPresenter<IEnumerable<SeguimientoDTO>>)OutputPort).Content;
        }
    }
}
