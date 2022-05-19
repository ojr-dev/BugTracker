using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _1_BugTracker.Models
{
    public class Invite
    {
        public int Id { get; set; }

        [Display(Name ="Date Sent")]
        public DateTimeOffset InviteDate { get; set; }

        [Display(Name = "Join Date")]
        public DateTimeOffset JoinDate { get; set; }


        [DisplayName("Code")]
        public Guid CompanyToken { get; set; }

        [DisplayName("Company")]
        public int CompanyId { get; set; }

        [DisplayName("Project")]
        public int ProjectId { get; set; }


        [Required, Display(Name = "Sender")]
        public string SenderId { get; set; }

        [Required, Display(Name = "Recipient ID")]
        public string RecipientId { get; set; }

        [DisplayName("Recipient First Name")]
        public string RecipientFirstName { get; set; }

        [DisplayName("Recipient Last Name")]
        public string RecipientLastName { get; set; }

        [DisplayName("Recipient Email")]
        public string RecipientEmail { get; set; }

        public bool IsVaid { get; set; }

        //Nav Properties
        public virtual Project Project { get; set; }    
        public virtual Company Company { get; set; }
        public virtual BT_User Sender { get; set; }
        public virtual BT_User Recipient { get; set; }
    }
}
