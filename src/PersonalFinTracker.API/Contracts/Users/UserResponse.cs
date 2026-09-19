namespace PersonalFinTracker.Api.Contracts.Users
{
    public class UserResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public UserResponse(Guid id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
    }
}