using DTOs;
using RepositoryEFCore;
using System.Runtime.InteropServices;
using UseCasePorts;

namespace UseCases.GEtAllPersonas
{
    public class GetAllPersonasInteractor : IGetAllPersonasInputPort
    {
        private readonly IPersonaRepository Repository;

        public readonly IGetAllPersonasOutputPort OutputPort;
        public GetAllPersonasInteractor(IPersonaRepository repository,
            IGetAllPersonasOutputPort outputPort)
            => (Repository, OutputPort) =
            (repository, outputPort);

        public async Task<Task> Handle()
        {
            var Personas = Repository.GetAll().Select(
                p => new PersonaDTO
                {
                    CodAsegurador = p.CodAsegurador,
                    CodMpioResidencia = p.CodMpioResidencia,
                    FechaNacimiento = p.FechaNacimiento,
                    IdPersona = p.IdPersona,
                    NroIdentificacion = p.NroIdentificacion,
                    PrimerApellido = p.PrimerApellido,
                    PrimerNombre = p.PrimerNombre,
                    SegundoApellido = p.SegundoApellido,
                    SegundoNombre = p.SegundoNombre,
                    Sexo = p.Sexo,
                    TipoIdentificacion = p.TipoIdentificacion

                });

            await OutputPort.Handle(Personas);
            return Task.CompletedTask;
        }
    }
}
