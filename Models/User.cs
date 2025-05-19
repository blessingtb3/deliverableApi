namespace DeliverableApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public int role { get; set; } // 0 for user, 1 for admin
    }
}