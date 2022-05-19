using System.ComponentModel;

namespace _1_BugTracker.Models
{
    public class TicketComment
    {
        public int Id { get; set; }

        [DisplayName("Comment")]
        public string Comment { get; set; }

        [DisplayName("Date Created")]
        public DateTimeOffset Created { get; set; }

        [DisplayName("Team Member")]
        public string UserId { get; set; }

        [DisplayName("Ticket #")]
        public int TicketId { get; set; }

        //navigation properties
        public virtual Ticket Ticket { get; set; }
        public virtual BT_User User { get; set; }
    }
}
