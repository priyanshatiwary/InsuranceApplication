using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InsuranceApp.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; } //pk
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        // Navigation property to represent the associated Role
        public Role Role { get; set; }

        [ForeignKey("Role")] // Foreign key to establish the relationship with the Role entity
        public int RoleId { get; set; }
    }
}
