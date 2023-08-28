using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCasePorts;

namespace Presenters
{
    public class GetAllPersonasPresenter : IGetAllPersonasOutputPort, IPresenter<IEnumerable<PersonaDTO> >
    {
        public IEnumerable<PersonaDTO> Content { get; private set; } = null!;

        public Task Handle(IEnumerable<PersonaDTO> Personas)
        {
            Content = Personas;
            return Task.CompletedTask;
        }
    }
}
