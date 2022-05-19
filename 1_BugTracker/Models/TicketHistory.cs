using System.ComponentModel;

namespace _1_BugTracker.Models
{
    public class TicketHistory
    {
        public int Id { get; set; }
        //annotaion
        [DisplayName("Updated Item")]
        public string Property { get; set; }

        [DisplayName("Previous")]
        public string OldValue { get; set; }

        [DisplayName("Current")]
        public string NewValue { get; set; }
        //date time offset gets current date/time for user relative to where they are in world

        [DisplayName("Date Modified")]
        public DateTimeOffset Created { get; set; }

        [DisplayName("Description of Change")]
        public string Description { get; set; }

        [DisplayName("Team Member")]
        public string UserId { get; set; }

        [DisplayName("Ticket #")]
        public int TicketId { get; set; }

        //navigation properties
        public virtual Ticket Ticket { get; set; }
        public virtual BT_User User { get; set; }


    }
}
