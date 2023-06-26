namespace SupplyCompany.Api.Common.IMapper;
public static class Mapping {
    public static IMapperConfigurationExpression General_cfg(this IMapperConfigurationExpression cfg) {
        cfg.CreateMap<LocationRequest, LocationCommand>();
        cfg.CreateMap<RatingRequest, RatingCommand>();
        return cfg;
    }
    public static IMapperConfigurationExpression Authentication_cfg(this IMapperConfigurationExpression cfg) {
        cfg.CreateMap<RegisterRequest, RegisterCommand>();
        cfg.CreateMap<LoginRequest, LoginCommand>();
        return cfg;
    }
    public static IMapperConfigurationExpression Customer_cfg(this IMapperConfigurationExpression cfg) {
        cfg.CreateMap<CreateCustomerRequest, CreateCustomerCommand>();
        return cfg;
    }
    public static IMapperConfigurationExpression Supplier_cfg(this IMapperConfigurationExpression cfg) {
        cfg.CreateMap<CreateSupplierRequest, CreateSupplierCommand>();
        return cfg;
    }
    public static IMapperConfigurationExpression Product_cfg(this IMapperConfigurationExpression cfg) {
        cfg.CreateMap<CreateProductRequest, CreateProductCommand>();
        cfg.CreateMap<SubProductRequest, SubProductCommand>();
        cfg.CreateMap<ProductAttributeRequest, ProductAttributeCommand>();
        return cfg;
    }
    public static IMapperConfigurationExpression ProductReview_cfg(this IMapperConfigurationExpression cfg) {
        cfg.CreateMap<CreateProductReviewRequest, CreateProductReviewCommand>();
        return cfg;
    }
    public static IMapperConfigurationExpression SupplierReview_cfg(this IMapperConfigurationExpression cfg) {
        cfg.CreateMap<CreateSupplierReviewRequest, CreateSupplierReviewCommand>();
        return cfg;
    }
    public static IMapperConfigurationExpression Order_cfg(this IMapperConfigurationExpression cfg) {
        cfg.CreateMap<CreateOrderRequest, CreateOrderCommand>();
        return cfg;
    }
    public static IMapperConfigurationExpression SupplyRequest_cfg(this IMapperConfigurationExpression cfg) {
        cfg.CreateMap<CreateSupplyRequestRequest, CreateSupplyRequestCommand>();
        return cfg;
    }
}