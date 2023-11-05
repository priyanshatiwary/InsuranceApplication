using System.ComponentModel.DataAnnotations;

namespace InsuranceApp.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; } //pk
        public string RoleName { get; set; } // name of the role : (admin,user,employee or customer)
        public bool IsActive {  get; set; }
    }
}
