namespace SupplyCompany.Domain.Models.supplyRequest;

public sealed class SupplyRequest : AggregateRoot<SupplyRequestId>{
    public ProductReviewId Product { get; }
    public SubProductId SubProduct { get; }
    public SupplierId Supplier { get; }
    public CustomerId Customer { get; }
    public int Quantity { get; }
    public int Price { get; }
    public int Discount { get; }
    public DateTime DateCreated { get; }
    public DateTime DateLastModified { get; }

    private SupplyRequest(
        SupplyRequestId Id,
        ProductReviewId Product,
        SubProductId SubProduct,
        SupplierId Supplier,
        CustomerId Customer,
        int Quantity,
        int Price,
        int Discount)
        : base(Id){
        this.Product = Product;
        this.SubProduct = SubProduct;
        this.Supplier = Supplier;
        this.Customer = Customer;
        this.Quantity = Quantity;
        this.Price = Price;
        this.Discount = Discount;
        this.DateCreated = DateTime.Now;
        this.DateLastModified = DateTime.Now;
    }
    public static SupplyRequest Create(
        ProductReviewId Product,
        SubProductId SubProduct,
        SupplierId Supplier,
        CustomerId Customer,
        int Quantity,
        int Price,
        int Discount) {
        //Todo:Validations
        return new(
            SupplyRequestId.Create(),
            Product,
            SubProduct,
            Supplier,
            Customer,
            Quantity, 
            Price,
            Discount);
    }
}