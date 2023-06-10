namespace SupplyCompany.Domain.Models.user
{
    public class User : AggregateRoot<UserId> {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public DateTime CreatedDateTime { get; private set; }
        public DateTime LastModifiedDateTime { get; private set; }

        private User(
            UserId Id,
            string FirstName,
            string LastName,
            string Email,
            string Password,
            DateTime CreatedDateTime,
            DateTime LastModifiedDateTime
        ) : base(Id){
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Password = Password;
            this.CreatedDateTime = CreatedDateTime;
            this.LastModifiedDateTime = LastModifiedDateTime;
        }
        public static User Create(
            string FirstName,
            string LastName,
            string Email,
            string Password) {
            //validation
            return new(
                UserId.Create(),
                FirstName,
                LastName,
                Email,
                Password,
                DateTime.UtcNow,
                DateTime.UtcNow);
        }
        public void Update(User newUser) {
            FirstName = newUser.FirstName;
            LastName = newUser.LastName;
            Email = newUser.Email;
            Password = newUser.Password;
            CreatedDateTime = newUser.CreatedDateTime;
            LastModifiedDateTime = DateTime.UtcNow;
        }
    }
}