namespace PersonalFinTracker.Api.Contracts.Users
{
    public class CreateUserRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public CreateUserRequest(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}