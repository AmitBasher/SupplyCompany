namespace SupplyCompany.Application;
public static class DependencyInjection {
    public static IServiceCollection AddApplication(this IServiceCollection services) {
        return services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly));
    }
}