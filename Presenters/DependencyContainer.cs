using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCasePorts;

namespace Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenter(this IServiceCollection services)
        {
            services.AddScoped<ICreatePersonaOutputPort, CreatePersonaPresenter>();
            services.AddScoped<IGetAllPersonasOutputPort, GetAllPersonasPresenter>();

            services.AddScoped<ICreateSeguimientoOutputPort, CreateSeguimientoPresenter>();
            services.AddScoped<IGetAllSeguimientoOutputPort, GetAllSeguimientoPresenter>();
            return services;
        }
    }
}
