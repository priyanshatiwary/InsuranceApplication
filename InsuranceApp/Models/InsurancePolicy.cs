using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims; 

namespace InsuranceApp.Models
{
    public class InsurancePolicy
    {
        [Key]
        public int PolicyNo { get; set; } //pk      
        public DateTime IssueDate { get; set; }// date when the insurance policy was issued   
        public DateTime MaturityDate { get; set; } // date when the insurance policy matures       
        public string PremiumType { get; set; } // type of premium payment (e.g., "Monthly," "Annual")

        public double PremiumAmount { get; set; } //amount of the premium payment
        public double SumAssured { get; set; } //sum assured by the insurance policy
        public string Status { get; set; } //status of the insurance policy (e.g., "Active," "Expired")
        public bool IsActive { get; set; }      
        public InsuranceScheme InsuranceScheme { get; set; } // Navigation property to represent the associated InsuranceScheme

        [ForeignKey("InsuranceScheme")]
        public int SchemeId { get; set; }   
        public Claim Claim { get; set; } // Navigation property to represent a claim associated with the policy

        [ForeignKey("Claim")]
        public int ClaimId { get; set; }       
        public Payment PaidPremiums { get; set; } // Navigation property to represent a payment associated with the policy

        [ForeignKey("Payment")]
        public int PaymentId { get; set; }
    }
}
