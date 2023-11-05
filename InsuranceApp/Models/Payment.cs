using System.ComponentModel.DataAnnotations;

namespace InsuranceApp.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; } //pk
        public string PaymentType { get; set; } // type of payment (e.g., "Credit Card," "Cash")
        public double Amount { get; set; } //payment amount
        public DateTime Date { get; set; } //date of payment        
        public double Tax { get; set; } // amount of tax associated with the payment
        public double TotalPayment { get; set; } //total payment amount, including tax
        public bool IsActive { get; set; }
    }
}
