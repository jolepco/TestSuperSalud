using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCasePorts;
using UseCases.CreatePersona;
using UseCases.CreateSeguimiento;
using UseCases.GEtAllPersonas;
using UseCases.GetAllSeguimientos;

namespace UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCases(this IServiceCollection services) 
        {
            services.AddTransient<ICreatePersonaInputPort, CreatePersonaInteractor>();
            services.AddTransient<IGetAllPersonasInputPort, GetAllPersonasInteractor>();

            services.AddTransient<ICreateSeguimientoInputPort, CreateSeguimientoInteractor>();
            services.AddTransient<IGetAllSeguimientoInputPort, GetAllSeguimientoInteractor>();

            return services;
        }
    }
}
