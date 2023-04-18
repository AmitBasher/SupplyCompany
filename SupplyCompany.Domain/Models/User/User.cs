namespace SupplyCompany.Domain.Models.user
{
    public abstract class User : AggregateRoot<UserId> {
        public string FirstName { get; }
        public string LastName { get; }
        public string Email { get; }
        public string Password { get; }
        public DateTime DateCreated { get; }
        public DateTime DateLastModified { get; }

        protected User(
            UserId Id,
            string FirstName,
            string LastName,
            string Email,
            string Password
        ) : base(Id){
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Password = Password;
            this.DateCreated = DateTime.Now;
            this.DateLastModified = DateTime.Now;
        }
        
    }
}