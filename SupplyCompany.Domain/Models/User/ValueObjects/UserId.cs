namespace SupplyCompany.Domain.Models.user
{
    public sealed class UserId : ID<UserId> {
        public UserId(Guid value) : base(value) {
        }
        public static UserId Create() => new UserId(Guid.NewGuid());
    }
}