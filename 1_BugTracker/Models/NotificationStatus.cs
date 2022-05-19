using System.ComponentModel;

namespace _1_BugTracker.Models
{
    public class NotificationStatus
    {
        public int Id { get; set; }

        [DisplayName("Status")]
        public string Name { get; set; }
    }
}
