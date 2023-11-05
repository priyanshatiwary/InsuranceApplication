using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InsuranceApp.Models
{
    public class Claim
    {
        [Key]
        public int ClaimId { get; set; } //pk
        public double ClaimAmount { get; set; } //insurance claim amount
        public double BankAccountNumber { get; set; } //bank account number where the claim amount is to be deposited
        public string BankIfscCode { get; set; } //IFSC code of the bank where the claim amount is to be deposited
        public DateTime Date { get; set; } //date when the claim was submitted or processed
        public string Status { get; set; } // status of the claim(e.g., "Pending," "Approved")      
        public InsurancePolicy Policy { get; set; } // Navigation property to represent the associated InsurancePolicy

        [ForeignKey("InsurancePolicy")]
        public int PolicyNo { get; set; }
    }
}
