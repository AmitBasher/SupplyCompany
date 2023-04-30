namespace SupplyCompany.Domain.Models.customer;

public sealed class Customer : AggregateRoot<CustomerId> {
    public UserId UserId { get; private set; }
    public Location ShippingAddress { get; private set; }

    private readonly List<Order> _orderHistory = new();
    private readonly List<ProductReview> _productReviews = new();
    private readonly List<SupplierReview> _supplierReviews = new();
    private readonly List<SupplyRequest> _currentRequests = new();
    public IReadOnlyList<Order> OrderHistory =>
        _orderHistory.AsReadOnly();
    public IReadOnlyList<ProductReview> ProductReviews =>
        _productReviews.AsReadOnly();
    public IReadOnlyList<SupplierReview> SupplierReviews =>
        _supplierReviews.AsReadOnly();
    public IReadOnlyList<SupplyRequest> CurrentRequests =>
        _currentRequests.AsReadOnly();
    private Customer(
        CustomerId Id,
        UserId UserId
        ) :base(Id) {
        this.UserId = UserId;
    }
    public static Customer Create(
        UserId UserId,
        Location ShippingAddress
        ) {
        //ToDo:Validations
        return new(
            CustomerId.Create(),
            UserId) { 
            ShippingAddress=ShippingAddress }; 
    }
}