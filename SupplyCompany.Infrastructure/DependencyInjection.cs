using Microsoft.Extensions.DependencyInjection;
using SupplyCompany.Infrastructure.DAL.Repository;

namespace SupplyCompany.Infrastructure {
    public static class DependencyInjection {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services) {
            return services.AddDbService()
                        .AddRepostories();
        }
        private static IServiceCollection AddDbService(this IServiceCollection services) {
            return services;
            //todo:AddDbService Injection
        }
        private static IServiceCollection AddRepostories(this IServiceCollection services) {
            return services;
            //todo:AddRepositories Injection
        }
    }
}
