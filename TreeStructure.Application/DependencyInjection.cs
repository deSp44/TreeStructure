using Microsoft.Extensions.DependencyInjection;
using TreeStructure.Application.Interfaces;
using TreeStructure.Application.Services;

namespace TreeStructure.Application
{
    public static class DependencyInjection
    {
        public static void AddServiceDependency(this IServiceCollection services)
        {
            services.AddTransient<IMainService, MainService>();
        }
    }
}
