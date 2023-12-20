using Microsoft.Extensions.DependencyInjection;

namespace PMRU.Persistance
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services)
        {
            return services;
        }
    }
}
