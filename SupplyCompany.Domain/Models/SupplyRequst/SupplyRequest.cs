namespace SupplyCompany.Domain.Models.supplyRequest;

public sealed class SupplyRequest : AggregateRoot<SupplyRequestId>{
    //public ProductReviewId ProductReviewId { get; private set; }
    //public SupplierReviewId SupplierReviewId { get; private set; }
    //public OrderId OrderId { get; private set; }
    public ProductId ProductId { get; private set; }
    public SubProductId SubProductId { get; private set; }
    public SupplierId SupplierId { get; private set; }
    public CustomerId CustomerId { get; private set; }
    public int Quantity { get; private set; }
    public int Price { get; private set; }
    public int Discount { get; private set; }
    public DateTime CreatedDateTime { get; private set; }
    public DateTime LastModifiedDateTime { get; private set; }

    private SupplyRequest(
        SupplyRequestId Id,
        ProductId ProductId,
        SubProductId SubProductId,
        SupplierId SupplierId,
        CustomerId CustomerId,
        int Quantity,
        int Price,
        int Discount,
        DateTime CreatedDateTime,
        DateTime LastModifiedDateTime)
        : base(Id){
        this.ProductId = ProductId;
        this.SubProductId = SubProductId;
        this.SupplierId = SupplierId;
        this.CustomerId = CustomerId;
        this.Quantity = Quantity;
        this.Price = Price;
        this.Discount = Discount;
        this.CreatedDateTime = CreatedDateTime;
        this.LastModifiedDateTime = LastModifiedDateTime;
    }
    public static SupplyRequest Create(
        ProductId ProductId,
        SubProductId SubProductId,
        SupplierId SupplierId,
        CustomerId CustomerId,
        int Quantity,
        int Price,
        int Discount) {
        //Todo:Validations
        return new(
            SupplyRequestId.Create(),
            ProductId,
            SubProductId,
            SupplierId,
            CustomerId,
            Quantity, 
            Price,
            Discount,
            DateTime.UtcNow,
            DateTime.UtcNow);
    }
}