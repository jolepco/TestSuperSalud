using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Design.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RepositoryEFCore.DataContext;
using RepositoryEFCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEFCore
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories( this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<DataContexDb>(opciones =>opciones.UseSqlServer(configuration.GetConnectionString("DataContexDbUSer")));
            services.AddScoped<IPersonaRepository, PersonaRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<ISeguimientoRepository, SeguimientoRepository>();
        
            return services;
        }
    }
}
