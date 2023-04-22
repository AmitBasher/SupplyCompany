namespace SupplyCompany.Domain.Models.order; 
public class Order : AggregateRoot<OrderId>{
    public CustomerId CustomerId { get; }
    public SupplierId SupplierId { get; }
    public OrderPriceValue OrderPrice { get; }
    public Location ShippingTo { get; }
    public DateTime CreatedDateTime { get; }
    private readonly List<SupplyRequest> _supplyRequests = new();
    public IReadOnlyList<SupplyRequest> SupplyRequests
        => _supplyRequests.AsReadOnly();
    private Order(
        OrderId Id,
        CustomerId CustomerId, 
        SupplierId SupplierId, 
        List<SupplyRequest> SupplyRequests,
        OrderPriceValue OrderPrice, 
        Location ShippingTo, 
        DateTime CreatedDateTime):base(Id) {
        this.CustomerId=CustomerId;
        this.SupplierId=SupplierId;
        this._supplyRequests=SupplyRequests;
        this.OrderPrice=OrderPrice;
        this.ShippingTo=ShippingTo;
        this.CreatedDateTime=CreatedDateTime;
    }
    public static Order Create(
        CustomerId CustomerId,
        SupplierId SupplierId,
        Location ShippingTo,
        params SupplyRequest[] SupplyRequests) {
        //validations
        if (SupplyRequests.Length<=0)
             throw new ArgumentException();
        return new(
            OrderId.Create(),
            CustomerId,
            SupplierId,
            SupplyRequests.ToList(),
            OrderPriceValue.Create(SupplyRequests),
            ShippingTo,
            DateTime.UtcNow);
    }
}
