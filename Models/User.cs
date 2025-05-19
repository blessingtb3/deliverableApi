


namespace DeliverableApi.Models
{

    public enum Role
    {
        Admin = 0,
        User = 1,
    }

    public class User
    {
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public Role UserRole { get; set; } // 0 for admin, 1 for user
    }
}