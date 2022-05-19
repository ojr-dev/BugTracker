using System.ComponentModel;

namespace _1_BugTracker.Models
{
    public class TicketStatus
    {
        public int Id { get; set; }

        [DisplayName("Status")]
        public string Name { get; set; }
    }
}
