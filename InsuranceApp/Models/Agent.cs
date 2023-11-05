using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InsuranceApp.Models
{
    public class Agent
    {
        [Key]
        public int AgentId { get; set; } //pk
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Qualification { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }        
        public User User { get; set; } // Navigation property to represent the associated User

        [ForeignKey("User")]
        public int UserId { get; set; }
        public List<Customer>? Customers { get; set; } //collection of Customer entities associated with this agent
        public double CommissionEarned { get; set; } //commission earned by the agent
        public bool IsActive { get; set; }
    }
}

