namespace SupplyCompany.Domain.Models.customer;

public sealed class Customer : AggregateRoot<CustomerId> {
    public UserId UserId { get; }
    public Location ShippingAddress { get; }
    public Location BillingAddress { get; }

    private readonly List<Order> _orderHistory = new();
    private readonly List<ProductReview> _productReviews = new();
    private readonly List<SupplierReview> _supplierReviews = new();
    public IReadOnlyList<Order> OrderHistory =>
        _orderHistory.AsReadOnly();
    public IReadOnlyList<ProductReview> ProductReviews =>
        _productReviews.AsReadOnly();
    public IReadOnlyList<SupplierReview> SupplierReviews =>
        _supplierReviews.AsReadOnly();

    private Customer(
        CustomerId Id,
        UserId UserId,
        Location ShippingAddress,
        Location BillingAddress) :
        base(Id) {
        this.UserId = UserId;
        this.ShippingAddress = ShippingAddress;
        this.BillingAddress = BillingAddress;
    }
    public static Customer Create(
        UserId UserId,
        Location ShippingAddress,
        Location BillingAddress) {

        //ToDo:Validations

        return new(
            CustomerId.Create(),
            UserId,
            ShippingAddress,
            BillingAddress
        ); ;
    }
}