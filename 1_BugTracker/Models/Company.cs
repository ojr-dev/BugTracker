using System.ComponentModel;

namespace _1_BugTracker.Models
{
    public class Company
    {
        public int Id { get; set; }

        [DisplayName("Company Name")]
        public string Name { get; set; }

        [DisplayName("Company Description")]
        public string Description { get; set; }

        //Navigation Prop
        public virtual ICollection<BT_User> Users { get; set; } = new HashSet<BT_User>(); 
        public virtual ICollection<Project> Projects { get; set; } = new HashSet<Project>();
    }

}

