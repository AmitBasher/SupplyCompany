namespace SupplyCompany.Api.Common;
public class MappingConfiguration {
    public static Mapper InitializeAutoMapper() {
        var config = new MapperConfiguration(cfg => {
            cfg.General_cfg();
            cfg.Authentication_cfg();
            cfg.Customer_cfg();
            cfg.Supplier_cfg();
            cfg.SupplierReview_cfg();
            cfg.Product_cfg();
            cfg.ProductReview_cfg();
            cfg.Order_cfg();
            cfg.SupplyRequest_cfg();
        });
        return new Mapper(config);
    }
}