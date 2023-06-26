namespace SupplyCompany.Infrastructure {
    public static class DependencyInjection {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
                                                                ConfigurationManager cfgm) {
            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
            services.AddAuth(cfgm);

            return services.AddDbService()
                        .AddRepostories();
        }
        private static IServiceCollection AddDbService(this IServiceCollection services) {
            return services.AddDbContext<DataContext>();
        }
        private static IServiceCollection AddRepostories(this IServiceCollection services) {
            return services.AddScoped<IUserRepository, UserRepository>()
                           .AddScoped<ICustomerRepository, CustomerRepository>()
                           .AddScoped<ISupplierRepository, SupplierRepository>()
                           .AddScoped<IProductRepository, ProductRepository>()
                           .AddScoped<IProductReviewRepository, ProductReviewRepository>()
                           .AddScoped<ISupplierReviewRepository, SupplierReviewRepository>()
                           .AddScoped<IOrderRepository, OrderRepository>()
                           .AddScoped<ISupplyRequestRepository, SupplyRequestRepository>();
            //todo:AddRepositories Injection
        }
        private static IServiceCollection AddAuth(
            this IServiceCollection services,
            ConfigurationManager configuration) {
            var jwtSettings = new JwtSettings() { Audience="All",ExpiryMinutes=10,Secret="Amiasrharhzsdfbzcxthdrthxdtgzzdzdtgt",Issuer="Basher"};
            configuration.Bind(JwtSettings.SectionName, jwtSettings);

            services.AddSingleton(Options.Create(jwtSettings));
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();

            services.AddAuthentication(defaultScheme: JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options => options.TokenValidationParameters = new TokenValidationParameters {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = jwtSettings.Issuer,
                    ValidAudience = jwtSettings.Audience,
                    IssuerSigningKey = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(jwtSettings.Secret)),
                });

            return services;
        }
    }
}
