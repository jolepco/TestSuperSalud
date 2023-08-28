using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCasePorts;

namespace Presenters
{
    public class CreateSeguimientoPresenter : ICreateSeguimientoOutputPort, IPresenter<SeguimientoDTO>
    {
        public SeguimientoDTO Content { get; private set; } = null!;

        public Task Handle(SeguimientoDTO seguimiento)
        {
            Content = seguimiento;
            return Task.CompletedTask;
        }
    }
}
