using Microsoft.Extensions.DependencyInjection;
using TreeStructure.Domain.Interfaces;
using TreeStructure.Infrastructure.Repositories;

namespace TreeStructure.Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructureDependency(this IServiceCollection services)
        {
            services.AddTransient<IMainRepository, MainRepository>();
        }
    }
}
