using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _1_BugTracker.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(50)]
        [DisplayName("Title")]
        public string Title { get; set; }

        [Required]
        //[DisplayName("Title")]
        public string Description { get; set; }

        [DataType(DataType.Date)]//
        [DisplayName("Date Created")]
        public DateTimeOffset CreatedDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Date Updated")]
        public DateTimeOffset? UpdatedDate { get; set; }

        public bool Archived { get; set; }


        [DisplayName("Project")]
        public int ProjectId { get; set; }


        [DisplayName("Ticket Owner")]
        public string OwnerUserId { get; set; }

        [DisplayName("Ticket Developer")]
        public string DeveloperUserId { get; set; }


        [DisplayName("Ticket Type")]
        public int TicketTypeId { get; set; }

        [DisplayName("Priority")]
        public int TicketPriorityId { get; set; }

        [DisplayName("Status")]
        public int TicketStatusId { get; set; }



        //Navigation properties, dont need to use virtual but we'll keep it. Nav props not stored in database
        public virtual TicketStatus TicketStatus { get; set; }
        public virtual TicketPriority TicketPriority { get; set; }
        public virtual TicketType TicketType { get; set; }  
        public virtual Project Project { get; set; }
        public virtual BT_User OwnerUser { get; set; }
        public virtual BT_User DeveloperUser { get; set; }

        //One to many relationship
        public virtual ICollection<TicketComment> TicketComments { get; set; } = new HashSet<TicketComment>();
        public virtual ICollection<TicketAttachment> TicketAttachments { get; set; } = new HashSet<TicketAttachment>();
        //public virtual ICollection<Notification> Notifications { get; set; } = new HashSet<Notification>();
        public virtual ICollection<TicketHistory> TicketHistories { get; set; } = new HashSet<TicketHistory>();

    }
}
