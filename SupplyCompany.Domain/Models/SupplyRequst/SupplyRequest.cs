namespace SupplyCompany.Domain.Models.supplyRequest
{
public sealed class SupplyRequest : AggregateRoot<SupplyRequestId>{
        public ProductId Product { get; }
        public UserId Supplier { get; }
        public int Quantity { get; }
        public int Price { get; }
        public DateTime DateCreated { get; }
        public DateTime DateLastModified { get; }

        private SupplyRequest(
            SupplyRequestId Id,
            ProductId Product,
            UserId Supplier,
            int Quantity,
            int Price)
            : base(Id){
            this.Product = Product;
            this.Supplier = Supplier;
            this.Quantity = Quantity;
            this.Price = Price;
            this.DateCreated = DateTime.Now;
            this.DateLastModified = DateTime.Now;
        }
        public static SupplyRequest Create(
            ProductId Product,
            UserId Supplier,
            int Quantity,
            int Price) {
            //Todo:Validations
            return new(
                SupplyRequestId.Create(),
                Product,
                Supplier, 
                Quantity, 
                Price);
        }
    }
}