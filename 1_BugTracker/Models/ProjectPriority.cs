using System.ComponentModel;

namespace _1_BugTracker.Models
{
    public class ProjectPriority
    {
        public int Id { get; set; }

        [DisplayName("Priority Title")]
        public string Name { get; set; }
    }
}
