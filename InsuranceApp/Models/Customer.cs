using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace InsuranceApp.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; } //pk
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Nominee { get; set; } // customer's nominee name
        public string NomineeRelation { get; set; } //nominee relation with customer        
        public Agent Agent { get; set; } // Navigation property to represent the associated Agent

        [ForeignKey("Agent")]
        public int AgentId { get; set; }       
        public List<InsurancePolicy> InsurancePolicies { get; set; } // collection of InsurancePolicy entities associated with this customer      
        public List<Document> Documents { get; set; } // collection of Document entities associated with this customer
        public bool IsActive { get; set; }
    }
}
