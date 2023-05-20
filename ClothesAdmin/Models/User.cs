namespace ClothesAdmin.Models
{
    public class User
    {
        public int Id { get; }
        public string Name { get; }
        public string Password { get; }
        public string Email { get; }
        public string Role { get; }
        public enum Roles
        {
            admin,
            vendedor,
        }

        public User(int id, string name,
            string password, string email, string role)
        {
            Id = id;
            Name = name;
            Password = password;
            Email = email;
            Role = role.ToString();
        }

    }
}
