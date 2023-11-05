using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InsuranceApp.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive {  get; set; }
        public User User { get; set; } // Navigation property to represent the associated User

        [ForeignKey("User")]
        public int UserId { get; set; }

    }
}
