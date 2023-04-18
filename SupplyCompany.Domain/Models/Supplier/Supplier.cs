using SupplyCompany.Domain.Models.Common;
using SupplyCompany.Domain.Models.user;

namespace SupplyCompany.Domain.Models.supplier
{
    public sealed class Supplier : User
    {
        private readonly List<SupplyRequest> _dealsHistory = new();
        public IReadOnlyList<SupplyRequest> DealsHistoryIds => _dealsHistory.AsReadOnly();
        
        public AverageRatings Rating { get; }
        public DateTime DateCreated { get; }
        public DateTime DateLastModified { get; }

        private Supplier(
            UserId Id,
            string FirstName,
            string LastName,
            string Email,
            string Password,
            AverageRatings Rating):
            base(Id,FirstName,LastName,Email,Password){
            this.Rating = Rating;
            this.DateCreated = DateTime.Now;
            this.DateLastModified = DateTime.Now;
        }

        public static Supplier CreateNew(
            string FirstName,
            string LastName,
            string Email,
            string Password) {
            //ToDo:Validations
            var supplier = new Supplier(
                UserId.Create(),
                FirstName,
                LastName,
                Email,
                Password,
                AverageRatings.CreateNew());
            UserFactory.CreateNew(supplier);
            return supplier;
        }
    }
}