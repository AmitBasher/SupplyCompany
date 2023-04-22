using SupplyCompany.Domain.Models.Common;
using SupplyCompany.Domain.Models.supplier;

namespace SupplyCompany.Domain.Models.supplierReview;
public class SupplierReview : AggregateRoot<SubProductId> {
    public CustomerId Customer { get; }
    public SupplierId Supplier { get; }
    public SupplyRequestId SupplyRequest { get; }
    public string Description { get; }
    public Rating Rating { get; }
    public DateTime CreatedDateTime { get; }
    public DateTime LastModifiedDateTime { get; }

    private SupplierReview(
        SubProductId Id,
        CustomerId Customer,
        SupplierId Supplier,
        SupplyRequestId SupplyRequest,
        string Description,
        Rating Rating,
        DateTime CreatedDateTime,
        DateTime LastModifiedDateTime) :base(Id) { 
        this.Customer = Customer;
        this.Supplier = Supplier;
        this.SupplyRequest = SupplyRequest;
        this.Description = Description;
        this.Rating = Rating;
        this.CreatedDateTime = CreatedDateTime;
        this.LastModifiedDateTime = LastModifiedDateTime;
    }
    public static SupplierReview Create(
        CustomerId Customer,
        SupplierId Supplier,
        SupplyRequestId SupplyRequest,
        string Description,
        Rating Rating) {
        //Validation
        return new(
            SubProductId.Create(),
            Customer,
            Supplier,
            SupplyRequest,
            Description, 
            Rating,
            DateTime.UtcNow,
            DateTime.UtcNow);
    }
}

