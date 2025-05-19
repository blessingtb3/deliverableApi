
namespace DeliverableApi.Models
{

    public enum DeliverableStatus
    {
        Due = 0,
        Completed = 1
    }

    public class Deliverable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DeliverableStatus Status { get; set; } // e.g., "Due: 0", "Completed: 1"
        public User AssignedUser { get; set; }
        public int UserId { get; set; }
    }
}