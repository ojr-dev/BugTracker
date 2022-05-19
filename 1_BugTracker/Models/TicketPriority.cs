using System.ComponentModel;

namespace _1_BugTracker.Models
{
    public class TicketPriority
    {
        public int Id { get; set; } 

        [DisplayName("Priority")]
        public string Name { get; set; }
    }
}
