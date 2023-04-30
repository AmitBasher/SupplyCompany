namespace SupplyCompany.Domain.Models.supplier;

public sealed class Supplier : AggregateRoot<SupplierId>{

    public UserId UserId { get; private set; }
    public AverageRatings Rating { get; private set; }
    private readonly List<Product> _products = new();
    private readonly List<SupplierReview> _reviews = new();
    private readonly List<Order> _ordersHistory = new();
    private readonly List<ProductReview> _productReviews = new();
    private readonly List<SupplyRequest> _pendingRequests = new();

    public IReadOnlyList<Product> Products => _products.AsReadOnly();
    public IReadOnlyList<SupplierReview> Reviews => _reviews.AsReadOnly();
    public IReadOnlyList<Order> OrdersHistory => _ordersHistory.AsReadOnly();
    public IReadOnlyList<ProductReview> ProductReviews => _productReviews.AsReadOnly();
    public IReadOnlyList<SupplyRequest> PendingRequests => _pendingRequests.AsReadOnly();
    private Supplier(
        SupplierId Id,
        UserId UserId
        ):base(Id) {
        this.UserId = UserId;
    }

    public static Supplier CreateNew(
        UserId UserId) {
        //ToDo:Validations
        var supplier = new Supplier(
            SupplierId.Create(),
            UserId) {
            Rating = AverageRatings.CreateNew() };
        return supplier;
    }
}