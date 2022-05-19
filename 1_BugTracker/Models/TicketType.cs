using System.ComponentModel;

namespace _1_BugTracker.Models
{
    //lookup table 1-1
    public class TicketType
    {
        public int Id { get; set; }

        [DisplayName("Ticket Type")]
        public string Name { get; set; }

    }
}
