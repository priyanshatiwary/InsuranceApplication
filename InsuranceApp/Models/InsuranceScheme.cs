using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InsuranceApp.Models
{
    public class InsuranceScheme
    {
        [Key]
        public int SchemeId { get; set; } //pk
        public string SchemeName { get; set; } //insurance scheme name
        public bool IsActive { get; set; }      
        public SchemeDetails SchemeDetails { get; set; }  // Navigation property to represent the associated SchemeDetails

        [ForeignKey("SchemeDetails")]
        public int DetailId { get; set; }
        public List<InsurancePolicy> Policies { get; set; } //collection of InsurancePolicy entities associated with this scheme
    }
}
