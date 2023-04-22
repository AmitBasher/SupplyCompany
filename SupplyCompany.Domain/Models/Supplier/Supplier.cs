namespace SupplyCompany.Domain.Models.supplier;

public sealed class Supplier : AggregateRoot<SupplierId>{

    public UserId UserId { get; set; }
    public AverageRatings Rating { get; }
    public DateTime DateCreated { get; }
    public DateTime DateLastModified { get; }
    private readonly List<Product> _products = new();
    private readonly List<SupplierReview> _reviews = new();
    private readonly List<Order> _ordersHistory = new();
    public IReadOnlyList<Product> Products => _products.AsReadOnly();
    public IReadOnlyList<SupplierReview> Reviews => _reviews.AsReadOnly();
    public IReadOnlyList<Order> OrdersHistoryIds => _ordersHistory.AsReadOnly();
    private Supplier(
        SupplierId Id,
        UserId UserId,
        DateTime DateCreated,
        DateTime DateLastModified,
        AverageRatings Rating):
        base(Id) {
        this.UserId = UserId;
        this.Rating = Rating;
        this.DateCreated = DateCreated;
        this.DateLastModified = DateLastModified;
    }

    public static Supplier CreateNew(
        UserId UserId) {
        //ToDo:Validations
        var supplier = new Supplier(
            SupplierId.Create(),
            UserId,
            DateTime.UtcNow,
            DateTime.UtcNow,
            AverageRatings.CreateNew());
        return supplier;
    }
}