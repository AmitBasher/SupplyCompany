using SupplyCompany.Domain.Models.supplyRequest;

namespace SupplyCompany.Domain.Models.order; 
public class Order : AggregateRoot<OrderId>{
    public CustomerId CustomerId { get; private set; }
    public SupplierId SupplierId { get; private set; }
    public OrderPriceValue OrderPriceValue { get; private set; }
    public Location ShippingTo { get; private set; }
    public DateTime CreatedDateTime { get; private set; }
    private List<SupplyRequest> _supplyRequests = new();
    public IReadOnlyList<SupplyRequest> SupplyRequests
        => _supplyRequests.AsReadOnly();
    private Order(
        OrderId Id,
        CustomerId CustomerId, 
        SupplierId SupplierId,
        DateTime CreatedDateTime
        //,List<SupplyRequestId> _supplyRequests
        ) : base(Id) {
        this.CustomerId=CustomerId;
        this.SupplierId=SupplierId;
        this.CreatedDateTime=CreatedDateTime;
        //this._supplyRequests=_supplyRequests;
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
            DateTime.UtcNow
            ) {
            ShippingTo = ShippingTo,
            OrderPriceValue = OrderPriceValue.Create(SupplyRequests),
            _supplyRequests = SupplyRequests.ToList()
        };
    }
}
