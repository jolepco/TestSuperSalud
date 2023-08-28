using DTOs;
using Entities.POCOs;
using RepositoryEFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using UseCasePorts;

namespace UseCases.CreatePersona
{
    public class CreatePersonaInteractor : ICreatePersonaInputPort
    {
        private readonly IPersonaRepository PersonaRepository;
        public readonly IUnitOfWork unitOfWork;
        public readonly ICreatePersonaOutputPort createPersonaOutputPort;

        public CreatePersonaInteractor(IPersonaRepository PersonaRepository,
            IUnitOfWork UnitOfWork,
            ICreatePersonaOutputPort CreatePersonaOutputPort)
        => (PersonaRepository, unitOfWork, createPersonaOutputPort) =
            (PersonaRepository, UnitOfWork, CreatePersonaOutputPort);


        public async Task Handle(CreatePersonaDTO Persona)
        {
            Persona NewPersona = new Persona()
            {
                CodAsegurador = Persona.CodAsegurador,
                CodMpioResidencia = Persona.CodMpioResidencia,
                Created = DateTime.Now,
                FechaNacimiento = Persona.FechaNacimiento,
                NroIdentificacion = Persona.NroIdentificacion,
                PrimerApellido = Persona.PrimerApellido,
                PrimerNombre = Persona.PrimerNombre,
                SegundoApellido = Persona.SegundoApellido,
                SegundoNombre = Persona.SegundoSegundo,
                Sexo = Persona.Sexo,
                TipoIdentificacion = Persona.TipoIdentificacion,
                Updated = DateTime.Now,

            };
            PersonaRepository.CreatePersona(NewPersona);
            await unitOfWork.SaveChanges();
            
            await createPersonaOutputPort.Handle(new PersonaDTO()
            {
                CodAsegurador = Persona.CodAsegurador,
                CodMpioResidencia = Persona.CodMpioResidencia,
                FechaNacimiento = Persona.FechaNacimiento,
                NroIdentificacion = Persona.NroIdentificacion,
                PrimerApellido = Persona.PrimerApellido,
                PrimerNombre = Persona.PrimerNombre,
                SegundoApellido = Persona.SegundoApellido,
                SegundoNombre = Persona.SegundoSegundo,
                Sexo = Persona.Sexo,
                TipoIdentificacion = Persona.TipoIdentificacion,
            }
            );
        }
    }
}
