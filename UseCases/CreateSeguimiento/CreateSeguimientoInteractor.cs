using DTOs;
using Entities.POCOs;
using RepositoryEFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCasePorts;

namespace UseCases.CreateSeguimiento
{
    public class CreateSeguimientoInteractor : ICreateSeguimientoInputPort
    {
        private readonly ISeguimientoRepository repository;
        public readonly IUnitOfWork unitOfWork;
        public readonly ICreateSeguimientoOutputPort OutputPort;
        public CreateSeguimientoInteractor(ISeguimientoRepository Repository,
              IUnitOfWork UnitOfWork,
              ICreateSeguimientoOutputPort outputPort)
          => (repository, unitOfWork,OutputPort) =
              (Repository, UnitOfWork, outputPort);


        public async Task Handle(CreateSeguimientoDTO Seguimiento)
        {
            Seguimiento NewSeguimiento = new Seguimiento()
            {
              CodClasificacionNutricional = Seguimiento.CodClasificacionNutricional, 
              CodLugarAtencion = Seguimiento.CodLugarAtencion,
              CodManejoActual=Seguimiento.CodManejoActual,  
              FechaAtencion= Seguimiento.FechaAtencion, 
              FechaDefuncion= Seguimiento.FechaAtencion, 
              IdPersona= Seguimiento.IdPersona,
              PesoKg= Seguimiento.PesoKg, 
              TallaCm = Seguimiento.TallaCm, 
            };

          repository.CreateSeguimiento(NewSeguimiento);
            await unitOfWork.SaveChanges();

            await OutputPort.Handle(new SeguimientoDTO()
            {
              //CodClasificacionNutricional = 1, 
              CodLugarAtencion =  NewSeguimiento.CodLugarAtencion, 
              CodManejoActual = NewSeguimiento.CodManejoActual, 
              FechaAtencion = NewSeguimiento.FechaAtencion, 
              FechaDefuncion= NewSeguimiento.FechaDefuncion, 
              IdSeguimiento = NewSeguimiento.IdSeguimiento, 
              PesoKg = NewSeguimiento.PesoKg, 
              TallaCm = NewSeguimiento.TallaCm, 
              IdPersona = NewSeguimiento.IdPersona,
              CodClasificacionNutricional = NewSeguimiento.CodClasificacionNutricional, 
              
            }
            );
        }
    }
}
