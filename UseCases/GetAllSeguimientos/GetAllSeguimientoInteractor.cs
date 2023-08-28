using DTOs;
using RepositoryEFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCasePorts;

namespace UseCases.GetAllSeguimientos
{
    public class GetAllSeguimientoInteractor : IGetAllSeguimientoInputPort
    {
        private readonly ISeguimientoRepository Repository;

        public readonly IGetAllSeguimientoOutputPort OutputPort;
        public GetAllSeguimientoInteractor(ISeguimientoRepository repository,
            IGetAllSeguimientoOutputPort outputPort)
            => (Repository, OutputPort) =
            (repository, outputPort);

        public async Task<Task> Handle()
        {
            var Seguimientos = Repository.GetAll().Select(
                p => new SeguimientoDTO
                {
//                    UbicacionDefuncion = p.ubicacionDefuncion, 
                    CodClasificacionNutricional =p.CodClasificacionNutricional, 
                    CodLugarAtencion = p.CodLugarAtencion, 
                    CodManejoActual = p.CodManejoActual,
//                    EstadoVital =p.estadoVital, 
                    FechaAtencion= p.FechaAtencion, 
                    FechaDefuncion= p.FechaDefuncion, 
                    IdSeguimiento = p.IdSeguimiento, 
                    PesoKg = p.PesoKg, 
                    TallaCm= p.TallaCm, 
                });

            await OutputPort.Handle(Seguimientos);
            return Task.CompletedTask;
        }
    }
}
