namespace SupplyCompany.Domain.Models.order;  
public class OrderPriceValue : ValueObject {
    public double Sum { get; private set; }
    private OrderPriceValue(double sum) {
        Sum=sum;
    }
    public override IEnumerable<object> GetEqualityComponents() {
        yield return Sum;
    }
    public static OrderPriceValue Create(IEnumerable<SupplyRequest> requests) {
        var Sum=0;
        foreach (var request in requests) {
            Sum+=request.Price*(1-request.Discount);
        }
        return new(Sum); 
    }
}
