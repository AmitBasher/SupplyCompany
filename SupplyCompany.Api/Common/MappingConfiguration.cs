namespace SupplyCompany.Api.Common;
public class MappingConfiguration {
    public static Mapper InitializeAutoMapper() {
        var config = new MapperConfiguration(cfg => {
            cfg.Authentication_cfg();
            cfg.Customer_cfg();
            cfg.Supplier_cfg();
        });
        return new Mapper(config);
    }
}
