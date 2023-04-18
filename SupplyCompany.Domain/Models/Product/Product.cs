namespace SupplyCompany.Domain.Models.product
{
    public sealed class Product : AggregateRoot<ProductId>{
        public UserId Supplier { get; set; }
        public string Name { get; }
        public string Description { get; }
        public int Price { get; }

        //split all below to another aggregate
        //for other types of same product
        public int SupplyAvailability { get; }
        public DateTime DateCreated { get; }
        public DateTime DateLastModified { get; }

        private List<ProductAttribute> Attributes { get; }
        public IReadOnlyCollection<ProductAttribute> ProductAttributes =>
            Attributes.AsReadOnly();
        public Product(
            ProductId Id,
            UserId supplier,
            string name,
            string description,
            int price,
            int supplyAvailability
        ): base(Id){
            this.Supplier = supplier;
            this.Name = name;
            this.Description = description;
            this.SupplyAvailability = supplyAvailability;
            this.Price = price;
            this.DateCreated = DateTime.Now;
            this.DateLastModified = DateTime.Now;
        }
    }
}