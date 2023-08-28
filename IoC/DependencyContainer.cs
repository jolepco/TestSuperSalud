using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Presenters;
using RepositoryEFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases;

namespace IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddIoc(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRepositories(configuration);
            services.AddUseCases();
            services.AddPresenter();
            return services;
        }
    }
}
