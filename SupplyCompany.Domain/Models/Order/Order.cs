using SupplyCompany.Domain.Models.supplyRequest;

namespace SupplyCompany.Domain.Models.order; 
public class Order : AggregateRoot<OrderId>{
    public CustomerId CustomerId { get; private set; }
    public SupplierId SupplierId { get; private set; }
    public OrderPriceValue OrderPriceValue { get; private set; }
    public Location ShippingTo { get; private set; }
    public DateTime CreatedDateTime { get; private set; }
    //private readonly List<SupplyRequest> _supplyRequests = new();
    //public IReadOnlyList<SupplyRequest> SupplyRequests
    //    => _supplyRequests.AsReadOnly();
    private Order(
        OrderId Id,
        CustomerId CustomerId, 
        SupplierId SupplierId, 
        DateTime CreatedDateTime):base(Id) {
        this.CustomerId=CustomerId;
        this.SupplierId=SupplierId;
        this.CreatedDateTime=CreatedDateTime;
    }
    
    public static Order Create(
        CustomerId CustomerId,
        SupplierId SupplierId,
        Location ShippingTo
        ,params SupplyRequest[] SupplyRequests
        ) {

        //validations

        return new(
            OrderId.Create(),
            CustomerId,
            SupplierId,
            DateTime.UtcNow) { 
            ShippingTo = ShippingTo,
            //_supplyRequests = SupplyRequests.ToList(),
            OrderPriceValue = OrderPriceValue.Create(SupplyRequests)};
    }
}
