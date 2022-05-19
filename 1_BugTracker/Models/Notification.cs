using System.ComponentModel.DataAnnotations;

namespace _1_BugTracker.Models
{
    public class Notification
    {            
        public int Id { get; set; }
        
        [Required]
        public string Title { get; set; }

        [Required]
        public int TicketId { get; set; }

        
        public int StatusId { get; set; }
        public virtual NotificationStatus Status { get; set; }

        [Required]
        [Display(Name ="Message")]
        public string Message { get; set; }

        [DataType(DataType.Date)]
        [Display(Name ="Date")]
        public DateTimeOffset CreatedDate { get; set; }

        [Required,Display(Name ="Sender")]
        public string SenderId { get; set; }

        [Required, Display(Name = "Recipient")]
        public string RecipientId { get; set; }

        [Display(Name ="Viewed?")]
        public bool Viewed { get; set; }

        //Nav props
        
        public virtual Ticket Ticket { get; set; }
        public virtual BT_User Sender { get; set; }
        public virtual BT_User Recipient { get; set; }

    }
}
