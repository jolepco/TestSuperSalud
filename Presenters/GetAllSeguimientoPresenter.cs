using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCasePorts;

namespace Presenters
{
    public class GetAllSeguimientoPresenter : IGetAllSeguimientoOutputPort, IPresenter<IEnumerable<SeguimientoDTO>>
    {
        public IEnumerable<SeguimientoDTO> Content { get; private set; } = null!;

        public Task Handle(IEnumerable<SeguimientoDTO> seguimiento)
        {
            Content = seguimiento;
            return Task.CompletedTask;
        }
    }
}
