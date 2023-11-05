using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InsuranceApp.Models
{
    public class InsurancePlan
    {
        [Key]
        public int PlanId { get; set; } //pk
        public string PlanName { get; set; } //insurance plan name
        public bool IsActive { get; set; }      
        public InsuranceScheme InsuranceScheme { get; set; } // Navigation property to represent the associated InsuranceScheme

        [ForeignKey("InsuranceScheme")]
        public int SchemeId { get; set; }
    }
}
