using SupplyCompany.Application.Users.Commands.Register;
using SupplyCompany.Application.Users.Queries.Login;
using SupplyCompany.DTO.Authentication;
using SupplyCompany.Application.Customers.Commands.Create;
using SupplyCompany.DTO.Customer;
using SupplyCompany.Application.Suppliers.Commands.Create;
using SupplyCompany.DTO.Supplier;

namespace SupplyCompany.Api.Common.IMapper;
public static class Mapping {
    public static IMapperConfigurationExpression Authentication_cfg(this IMapperConfigurationExpression cfg) {
        cfg.CreateMap<RegisterRequest, RegisterCommand>();
        cfg.CreateMap<LoginRequest, LoginCommand>();
        return cfg;
    }
    public static IMapperConfigurationExpression Customer_cfg(this IMapperConfigurationExpression cfg) {
        cfg.CreateMap<CreateCustomerRequest, CreateCustomerCommand>();
        cfg.CreateMap<LocationRequest, LocationCommand>();
        return cfg;
    }
    public static IMapperConfigurationExpression Supplier_cfg(this IMapperConfigurationExpression cfg) {
        cfg.CreateMap<CreateSupplierRequest, CreateSupplierCommand>();
        return cfg;
    }
}