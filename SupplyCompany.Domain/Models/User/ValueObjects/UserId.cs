using System.ComponentModel;

namespace SupplyCompany.Domain.Models.user
{
    public sealed class UserId : ID<UserId> {
        public UserId(Guid value) : base(value) {
        }
        public static UserId Create() => new(Guid.NewGuid());
        public static UserId CreateFrom(Guid id) => new(id);
        public static UserId CreateFrom(string id) => new(Guid.Parse(id));
    }
}